/*
 *  Copyright (C) 2005-2011 Team MediaPortal
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

#include <afx.h>
#include <afxwin.h>

#include <streams.h>
#include "Packet.h"

// For more details for memory leak detection see the alloctracing.h header
#include "..\..\alloctracing.h"

Packet::Packet() 
{ 
  nClipNumber = -100;
  nPlaylist = -100;
  bDiscontinuity = false;
  bSyncPoint = false;
  bSeekRequired = false;
  rtStart = -100;
  rtStop = -100;
  rtOffset = 0;//-100; /// is this needed? i.e. fixed somewhere else so that all packets will have a valid offset (initial versions did have some packets where this was left at -100)
  pmt = NULL;
}

Packet::~Packet() 
{
  if (pmt) 
  {
    DeleteMediaType(pmt);
  }
}

int Packet::GetDataSize() 
{
  return GetCount();
}

void Packet::SetData(const void* ptr, DWORD len) 
{
  SetCount(len); 
  memcpy(GetData(), ptr, len);
}
