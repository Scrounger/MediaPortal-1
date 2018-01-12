/* 
 *  Copyright (C) 2006-2008 Team MediaPortal
 *  http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */
#include "..\shared\SectionDecoder.h"
#include <cstddef>    // NULL
#include "..\shared\PacketSync.h"
#include "..\shared\TsHeader.h"


#define CONTINUITY_COUNTER_NOT_SET 0xff


extern void LogDebug(const wchar_t* fmt, ...);

CSectionDecoder::CSectionDecoder(ISectionDispatcher* dispatcher)
{
  m_pid = -1;
  m_section.Reset();
  m_continuityCounter = CONTINUITY_COUNTER_NOT_SET;
  m_isCrcCheckEnabled = true;
  m_callback = NULL;
  m_dispatcher = dispatcher;
}

CSectionDecoder::~CSectionDecoder()
{
  if (m_dispatcher != NULL)
  {
    m_dispatcher->DequeueSections(*this);
  }
}

void CSectionDecoder::Reset()
{
  m_section.Reset();
  m_continuityCounter = CONTINUITY_COUNTER_NOT_SET;
  if (m_dispatcher != NULL)
  {
    m_dispatcher->DequeueSections(*this);
  }
}

void CSectionDecoder::SetCallBack(ISectionCallback* callBack)
{
  m_callback = callBack;
}

void CSectionDecoder::SetPid(int pid)
{
  m_pid = pid;
  if (m_pid != -1 && m_pid != pid)
  {
    Reset();
  }
}

int CSectionDecoder::GetPid() const
{
  return m_pid;
}

void CSectionDecoder::EnableCrcCheck(bool enable)
{
  m_isCrcCheckEnabled = enable;
}

void CSectionDecoder::OnTsPacket(const unsigned char* tsPacket)
{
  if (m_pid < 0 || tsPacket == NULL)
  {
    return;
  }

  m_header.Decode(tsPacket);
  OnTsPacket(m_header, tsPacket);
}

void CSectionDecoder::OnTsPacket(const CTsHeader& header, const unsigned char* tsPacket)
{
  try
  {
    if (header.Pid != m_pid || !header.HasPayload)
    {
      return;
    }
    if (header.TransportError) 
    {
      // Give up on the current section.
      LogDebug(L"section decoder %d: transport error flag set, signal quality problem?",
                m_pid);
      m_section.Reset();
      m_continuityCounter = CONTINUITY_COUNTER_NOT_SET;
      return; 
    }

    // Check the continuity counter is as expected.
    if (m_continuityCounter != CONTINUITY_COUNTER_NOT_SET)
    {
      unsigned char expectedContinuityCounter = (m_continuityCounter + 1) & 0x0f;
      if (header.ContinuityCounter != expectedContinuityCounter)
      {
        LogDebug(L"section decoder %d: discontinuity, value = %hhu, previous = %hhu, expected = %hhu, signal quality, descrambling, or HDD load problem?",
                  m_pid, header.ContinuityCounter, m_continuityCounter,
                  expectedContinuityCounter);
        m_section.Reset();
        m_continuityCounter = header.ContinuityCounter;
        return; 
      }
    }
    m_continuityCounter = header.ContinuityCounter;

    if (header.TScrambling != 0)
    {
      // We don't support decoding encrypted sections. This check helps to
      // avoid collection of data that isn't actually section data. For
      // example, the EPG grabber may create a section decoder for PID 0x300.
      // That PID carries EPG for Dish Network... but may well be used for
      // something else by other providers.
      m_section.Reset();
      return;
    }

    unsigned char packetPointer = header.PayLoadStart;
    if (header.PayloadUnitStart)
    {
      if (packetPointer >= TS_PACKET_LEN)
      {
        LogDebug(L"section decoder %d: invalid payload start, position = %hhu",
                  m_pid, packetPointer);
        m_section.Reset();
        return;
      }

      // The TS packet may contain the last part of a previous section. If the
      // buffer is expecting a new section, skip the pointer field and the
      // previous section data. Otherwise just skip the pointer field.
      if (m_section.IsEmpty())
      {
        packetPointer += tsPacket[packetPointer] + 1;
      }
      else
      {
        packetPointer++;
      }
    }
    unsigned char loopCount = 0;
    while (packetPointer < TS_PACKET_LEN)
    {
      loopCount++;
      if (m_section.IsEmpty())
      {
        if (!header.PayloadUnitStart)
        {
          // We need to wait for the start of the next section.
          return;
        }
        if (tsPacket[packetPointer] == 0xff)
        {
          // No more section data remains in the packet.
          return;
        }
      }

      packetPointer += m_section.AppendData(&tsPacket[packetPointer], TS_PACKET_LEN - packetPointer);
      if (m_section.IsComplete())
      {
        // Sanity check: sections with table 0 (PAT) should only ever be
        // carried on PID 0. This check helps managing non-section data that
        // has been collected erroneously. It only works for unencrypted
        // packetised elementary streams, which contain packets that start with
        // the byte sequence: 00 00 01.
        if (m_pid == 0 || m_section.TableId != 0)
        {
          // Is the section valid?
          if (!m_isCrcCheckEnabled || m_section.IsValid(m_pid))
          {
            if (m_dispatcher != NULL)
            {
              m_dispatcher->EnqueueSection(m_pid, m_section.TableId, m_section, *this);
            }
            else
            {
              OnNewSection(m_pid, m_section.TableId, m_section);
            }
          }
        }
        m_section.Reset();
        continue;
      }

      if (loopCount > 100)
      {
        LogDebug(L"section decoder %d: entered infinite loop, packet pointer = %hhu, discarding packet/section",
                  m_pid, packetPointer);
        m_section.Debug();
        m_section.Reset();
        return;
      }
    }
  }
  catch (...)
  {
    LogDebug(L"section %d: unhandled exception in OnTsPacket()", m_pid);
  }
}

void CSectionDecoder::OnNewSection(const CSection& section)
{
}

void CSectionDecoder::OnNewSection(CSection& section)
{
  // TODO Remove. TsWriter overrides OnNewSection(const). All section handling
  // will be broken without this default implementation. This non-const
  // OnNewSection() is only kept for compatibility with TsReader.
  OnNewSection((const CSection&)section);
}

void CSectionDecoder::OnNewSection(unsigned short pid, unsigned char tableId, const CSection& section)
{
  OnNewSection(const_cast<CSection&>(section));
  if (m_callback != NULL)
  {
    m_callback->OnNewSection(pid, tableId, section);
  }
}