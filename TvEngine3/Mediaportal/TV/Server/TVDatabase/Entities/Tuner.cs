//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Mediaportal.TV.Server.TVDatabase.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(TunerTuningDetailMapping))]
    [KnownType(typeof(TunerGroup))]
    [KnownType(typeof(TunerProperty))]
    [KnownType(typeof(AnalogTunerSettings))]
    [KnownType(typeof(Conflict))]
    [KnownType(typeof(TunerSatellite))]
    [KnownType(typeof(StreamTunerSettings))]
    public partial class Tuner: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int IdTuner
        {
            get { return _idTuner; }
            set
            {
                if (_idTuner != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'IdTuner' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _idTuner = value;
                    OnPropertyChanged("IdTuner");
                }
            }
        }
        private int _idTuner;
    
        [DataMember]
        public string ExternalId
        {
            get { return _externalId; }
            set
            {
                if (_externalId != value)
                {
                    _externalId = value;
                    OnPropertyChanged("ExternalId");
                }
            }
        }
        private string _externalId;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
    
        [DataMember]
        public int Priority
        {
            get { return _priority; }
            set
            {
                if (_priority != value)
                {
                    _priority = value;
                    OnPropertyChanged("Priority");
                }
            }
        }
        private int _priority;
    
        [DataMember]
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }
        private bool _isEnabled;
    
        [DataMember]
        public bool UseForEpgGrabbing
        {
            get { return _useForEpgGrabbing; }
            set
            {
                if (_useForEpgGrabbing != value)
                {
                    _useForEpgGrabbing = value;
                    OnPropertyChanged("UseForEpgGrabbing");
                }
            }
        }
        private bool _useForEpgGrabbing;
    
        [DataMember]
        public int SupportedBroadcastStandards
        {
            get { return _supportedBroadcastStandards; }
            set
            {
                if (_supportedBroadcastStandards != value)
                {
                    _supportedBroadcastStandards = value;
                    OnPropertyChanged("SupportedBroadcastStandards");
                }
            }
        }
        private int _supportedBroadcastStandards;
    
        [DataMember]
        public bool UseConditionalAccess
        {
            get { return _useConditionalAccess; }
            set
            {
                if (_useConditionalAccess != value)
                {
                    _useConditionalAccess = value;
                    OnPropertyChanged("UseConditionalAccess");
                }
            }
        }
        private bool _useConditionalAccess;
    
        [DataMember]
        public int CamType
        {
            get { return _camType; }
            set
            {
                if (_camType != value)
                {
                    _camType = value;
                    OnPropertyChanged("CamType");
                }
            }
        }
        private int _camType;
    
        [DataMember]
        public int DecryptLimit
        {
            get { return _decryptLimit; }
            set
            {
                if (_decryptLimit != value)
                {
                    _decryptLimit = value;
                    OnPropertyChanged("DecryptLimit");
                }
            }
        }
        private int _decryptLimit;
    
        [DataMember]
        public int MultiChannelDecryptMode
        {
            get { return _multiChannelDecryptMode; }
            set
            {
                if (_multiChannelDecryptMode != value)
                {
                    _multiChannelDecryptMode = value;
                    OnPropertyChanged("MultiChannelDecryptMode");
                }
            }
        }
        private int _multiChannelDecryptMode;
    
        [DataMember]
        public string ConditionalAccessProviders
        {
            get { return _conditionalAccessProviders; }
            set
            {
                if (_conditionalAccessProviders != value)
                {
                    _conditionalAccessProviders = value;
                    OnPropertyChanged("ConditionalAccessProviders");
                }
            }
        }
        private string _conditionalAccessProviders;
    
        [DataMember]
        public bool Preload
        {
            get { return _preload; }
            set
            {
                if (_preload != value)
                {
                    _preload = value;
                    OnPropertyChanged("Preload");
                }
            }
        }
        private bool _preload;
    
        [DataMember]
        public int BdaNetworkProvider
        {
            get { return _bdaNetworkProvider; }
            set
            {
                if (_bdaNetworkProvider != value)
                {
                    _bdaNetworkProvider = value;
                    OnPropertyChanged("BdaNetworkProvider");
                }
            }
        }
        private int _bdaNetworkProvider;
    
        [DataMember]
        public int IdleMode
        {
            get { return _idleMode; }
            set
            {
                if (_idleMode != value)
                {
                    _idleMode = value;
                    OnPropertyChanged("IdleMode");
                }
            }
        }
        private int _idleMode;
    
        [DataMember]
        public bool AlwaysSendDiseqcCommands
        {
            get { return _alwaysSendDiseqcCommands; }
            set
            {
                if (_alwaysSendDiseqcCommands != value)
                {
                    _alwaysSendDiseqcCommands = value;
                    OnPropertyChanged("AlwaysSendDiseqcCommands");
                }
            }
        }
        private bool _alwaysSendDiseqcCommands;
    
        [DataMember]
        public int PidFilterMode
        {
            get { return _pidFilterMode; }
            set
            {
                if (_pidFilterMode != value)
                {
                    _pidFilterMode = value;
                    OnPropertyChanged("PidFilterMode");
                }
            }
        }
        private int _pidFilterMode;
    
        [DataMember]
        public bool UseCustomTuning
        {
            get { return _useCustomTuning; }
            set
            {
                if (_useCustomTuning != value)
                {
                    _useCustomTuning = value;
                    OnPropertyChanged("UseCustomTuning");
                }
            }
        }
        private bool _useCustomTuning;
    
        [DataMember]
        public Nullable<int> IdTunerGroup
        {
            get { return _idTunerGroup; }
            set
            {
                if (_idTunerGroup != value)
                {
                    ChangeTracker.RecordOriginalValue("IdTunerGroup", _idTunerGroup);
                    if (!IsDeserializing)
                    {
                        if (TunerGroup != null && TunerGroup.IdTunerGroup != value)
                        {
                            TunerGroup = null;
                        }
                    }
                    _idTunerGroup = value;
                    OnPropertyChanged("IdTunerGroup");
                }
            }
        }
        private Nullable<int> _idTunerGroup;
    
        [DataMember]
        public int TsWriterInputDumpMask
        {
            get { return _tsWriterInputDumpMask; }
            set
            {
                if (_tsWriterInputDumpMask != value)
                {
                    _tsWriterInputDumpMask = value;
                    OnPropertyChanged("TsWriterInputDumpMask");
                }
            }
        }
        private int _tsWriterInputDumpMask;
    
        [DataMember]
        public int TsMuxerInputDumpMask
        {
            get { return _tsMuxerInputDumpMask; }
            set
            {
                if (_tsMuxerInputDumpMask != value)
                {
                    _tsMuxerInputDumpMask = value;
                    OnPropertyChanged("TsMuxerInputDumpMask");
                }
            }
        }
        private int _tsMuxerInputDumpMask;
    
        [DataMember]
        public bool DisableTsWriterCrcChecking
        {
            get { return _disableTsWriterCrcChecking; }
            set
            {
                if (_disableTsWriterCrcChecking != value)
                {
                    _disableTsWriterCrcChecking = value;
                    OnPropertyChanged("DisableTsWriterCrcChecking");
                }
            }
        }
        private bool _disableTsWriterCrcChecking;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<TunerTuningDetailMapping> TuningDetailMappings
        {
            get
            {
                if (_tuningDetailMappings == null)
                {
                    _tuningDetailMappings = new TrackableCollection<TunerTuningDetailMapping>();
                    _tuningDetailMappings.CollectionChanged += FixupTuningDetailMappings;
                }
                return _tuningDetailMappings;
            }
            set
            {
                if (!ReferenceEquals(_tuningDetailMappings, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_tuningDetailMappings != null)
                    {
                        _tuningDetailMappings.CollectionChanged -= FixupTuningDetailMappings;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (TunerTuningDetailMapping item in _tuningDetailMappings)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _tuningDetailMappings = value;
                    if (_tuningDetailMappings != null)
                    {
                        _tuningDetailMappings.CollectionChanged += FixupTuningDetailMappings;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (TunerTuningDetailMapping item in _tuningDetailMappings)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("TuningDetailMappings");
                }
            }
        }
        private TrackableCollection<TunerTuningDetailMapping> _tuningDetailMappings;
    
        [DataMember]
        public TunerGroup TunerGroup
        {
            get { return _tunerGroup; }
            set
            {
                if (!ReferenceEquals(_tunerGroup, value))
                {
                    var previousValue = _tunerGroup;
                    _tunerGroup = value;
                    FixupTunerGroup(previousValue);
                    OnNavigationPropertyChanged("TunerGroup");
                }
            }
        }
        private TunerGroup _tunerGroup;
    
        [DataMember]
        public TrackableCollection<TunerProperty> TunerProperties
        {
            get
            {
                if (_tunerProperties == null)
                {
                    _tunerProperties = new TrackableCollection<TunerProperty>();
                    _tunerProperties.CollectionChanged += FixupTunerProperties;
                }
                return _tunerProperties;
            }
            set
            {
                if (!ReferenceEquals(_tunerProperties, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_tunerProperties != null)
                    {
                        _tunerProperties.CollectionChanged -= FixupTunerProperties;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (TunerProperty item in _tunerProperties)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _tunerProperties = value;
                    if (_tunerProperties != null)
                    {
                        _tunerProperties.CollectionChanged += FixupTunerProperties;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (TunerProperty item in _tunerProperties)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("TunerProperties");
                }
            }
        }
        private TrackableCollection<TunerProperty> _tunerProperties;
    
        [DataMember]
        public AnalogTunerSettings AnalogTunerSettings
        {
            get { return _analogTunerSettings; }
            set
            {
                if (!ReferenceEquals(_analogTunerSettings, value))
                {
                    var previousValue = _analogTunerSettings;
                    _analogTunerSettings = value;
                    FixupAnalogTunerSettings(previousValue);
                    OnNavigationPropertyChanged("AnalogTunerSettings");
                }
            }
        }
        private AnalogTunerSettings _analogTunerSettings;
    
        [DataMember]
        public TrackableCollection<Conflict> Conflicts
        {
            get
            {
                if (_conflicts == null)
                {
                    _conflicts = new TrackableCollection<Conflict>();
                    _conflicts.CollectionChanged += FixupConflicts;
                }
                return _conflicts;
            }
            set
            {
                if (!ReferenceEquals(_conflicts, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_conflicts != null)
                    {
                        _conflicts.CollectionChanged -= FixupConflicts;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (Conflict item in _conflicts)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _conflicts = value;
                    if (_conflicts != null)
                    {
                        _conflicts.CollectionChanged += FixupConflicts;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (Conflict item in _conflicts)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("Conflicts");
                }
            }
        }
        private TrackableCollection<Conflict> _conflicts;
    
        [DataMember]
        public TrackableCollection<TunerSatellite> TunerSatellites
        {
            get
            {
                if (_tunerSatellites == null)
                {
                    _tunerSatellites = new TrackableCollection<TunerSatellite>();
                    _tunerSatellites.CollectionChanged += FixupTunerSatellites;
                }
                return _tunerSatellites;
            }
            set
            {
                if (!ReferenceEquals(_tunerSatellites, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_tunerSatellites != null)
                    {
                        _tunerSatellites.CollectionChanged -= FixupTunerSatellites;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (TunerSatellite item in _tunerSatellites)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _tunerSatellites = value;
                    if (_tunerSatellites != null)
                    {
                        _tunerSatellites.CollectionChanged += FixupTunerSatellites;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (TunerSatellite item in _tunerSatellites)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("TunerSatellites");
                }
            }
        }
        private TrackableCollection<TunerSatellite> _tunerSatellites;
    
        [DataMember]
        public StreamTunerSettings StreamTunerSettings
        {
            get { return _streamTunerSettings; }
            set
            {
                if (!ReferenceEquals(_streamTunerSettings, value))
                {
                    var previousValue = _streamTunerSettings;
                    _streamTunerSettings = value;
                    FixupStreamTunerSettings(previousValue);
                    OnNavigationPropertyChanged("StreamTunerSettings");
                }
            }
        }
        private StreamTunerSettings _streamTunerSettings;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            TuningDetailMappings.Clear();
            TunerGroup = null;
            TunerProperties.Clear();
            AnalogTunerSettings = null;
            Conflicts.Clear();
            TunerSatellites.Clear();
            StreamTunerSettings = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupTunerGroup(TunerGroup previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Tuners.Contains(this))
            {
                previousValue.Tuners.Remove(this);
            }
    
            if (TunerGroup != null)
            {
                if (!TunerGroup.Tuners.Contains(this))
                {
                    TunerGroup.Tuners.Add(this);
                }
    
                IdTunerGroup = TunerGroup.IdTunerGroup;
            }
            else if (!skipKeys)
            {
                IdTunerGroup = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("TunerGroup")
                    && (ChangeTracker.OriginalValues["TunerGroup"] == TunerGroup))
                {
                    ChangeTracker.OriginalValues.Remove("TunerGroup");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("TunerGroup", previousValue);
                }
                if (TunerGroup != null && !TunerGroup.ChangeTracker.ChangeTrackingEnabled)
                {
                    TunerGroup.StartTracking();
                }
            }
        }
    
        private void FixupAnalogTunerSettings(AnalogTunerSettings previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (AnalogTunerSettings != null)
            {
                ChangeTracker.ObjectStateChanging += AnalogTunerSettings.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.Tuner, this))
            {
                previousValue.Tuner = null;
            }
    
            if (AnalogTunerSettings != null)
            {
                AnalogTunerSettings.Tuner = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("AnalogTunerSettings")
                    && (ChangeTracker.OriginalValues["AnalogTunerSettings"] == AnalogTunerSettings))
                {
                    ChangeTracker.OriginalValues.Remove("AnalogTunerSettings");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("AnalogTunerSettings", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (AnalogTunerSettings != null && !AnalogTunerSettings.ChangeTracker.ChangeTrackingEnabled)
                {
                    AnalogTunerSettings.StartTracking();
                }
            }
        }
    
        private void FixupStreamTunerSettings(StreamTunerSettings previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (StreamTunerSettings != null)
            {
                ChangeTracker.ObjectStateChanging += StreamTunerSettings.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.Tuner, this))
            {
                previousValue.Tuner = null;
            }
    
            if (StreamTunerSettings != null)
            {
                StreamTunerSettings.Tuner = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("StreamTunerSettings")
                    && (ChangeTracker.OriginalValues["StreamTunerSettings"] == StreamTunerSettings))
                {
                    ChangeTracker.OriginalValues.Remove("StreamTunerSettings");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("StreamTunerSettings", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (StreamTunerSettings != null && !StreamTunerSettings.ChangeTracker.ChangeTrackingEnabled)
                {
                    StreamTunerSettings.StartTracking();
                }
            }
        }
    
        private void FixupTuningDetailMappings(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (TunerTuningDetailMapping item in e.NewItems)
                {
                    item.Tuner = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("TuningDetailMappings", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (TunerTuningDetailMapping item in e.OldItems)
                {
                    if (ReferenceEquals(item.Tuner, this))
                    {
                        item.Tuner = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("TuningDetailMappings", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupTunerProperties(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (TunerProperty item in e.NewItems)
                {
                    item.Tuner = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("TunerProperties", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (TunerProperty item in e.OldItems)
                {
                    if (ReferenceEquals(item.Tuner, this))
                    {
                        item.Tuner = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("TunerProperties", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupConflicts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Conflict item in e.NewItems)
                {
                    item.Tuner = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Conflicts", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Conflict item in e.OldItems)
                {
                    if (ReferenceEquals(item.Tuner, this))
                    {
                        item.Tuner = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Conflicts", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupTunerSatellites(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (TunerSatellite item in e.NewItems)
                {
                    item.Tuner = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("TunerSatellites", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (TunerSatellite item in e.OldItems)
                {
                    if (ReferenceEquals(item.Tuner, this))
                    {
                        item.Tuner = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("TunerSatellites", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }

        #endregion
    }
}
