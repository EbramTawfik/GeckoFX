namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapMessagesListingEvent : WebIDLBase
    {
        
        public BluetoothMapMessagesListingEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint MaxListCount
        {
            get
            {
                return this.GetProperty<uint>("maxListCount");
            }
        }
        
        public uint ListStartOffset
        {
            get
            {
                return this.GetProperty<uint>("listStartOffset");
            }
        }
        
        public uint SubjectLength
        {
            get
            {
                return this.GetProperty<uint>("subjectLength");
            }
        }
        
        public ParameterMask[] ParameterMask
        {
            get
            {
                return this.GetProperty<ParameterMask[]>("parameterMask");
            }
        }
        
        public MessageType FilterMessageType
        {
            get
            {
                return this.GetProperty<MessageType>("filterMessageType");
            }
        }
        
        public nsAString FilterPeriodBegin
        {
            get
            {
                return this.GetProperty<nsAString>("filterPeriodBegin");
            }
        }
        
        public nsAString FilterPeriodEnd
        {
            get
            {
                return this.GetProperty<nsAString>("filterPeriodEnd");
            }
        }
        
        public ReadStatus FilterReadStatus
        {
            get
            {
                return this.GetProperty<ReadStatus>("filterReadStatus");
            }
        }
        
        public nsAString FilterRecipient
        {
            get
            {
                return this.GetProperty<nsAString>("filterRecipient");
            }
        }
        
        public nsAString FilterOriginator
        {
            get
            {
                return this.GetProperty<nsAString>("filterOriginator");
            }
        }
        
        public Priority FilterPriority
        {
            get
            {
                return this.GetProperty<Priority>("filterPriority");
            }
        }
        
        public nsISupports Handle
        {
            get
            {
                return this.GetProperty<nsISupports>("handle");
            }
        }
    }
}
