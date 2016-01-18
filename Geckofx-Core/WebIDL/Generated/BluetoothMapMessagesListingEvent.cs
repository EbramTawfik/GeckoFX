namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapMessagesListingEvent : WebIDLBase
    {
        
        public BluetoothMapMessagesListingEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string FilterPeriodBegin
        {
            get
            {
                return this.GetProperty<string>("filterPeriodBegin");
            }
        }
        
        public string FilterPeriodEnd
        {
            get
            {
                return this.GetProperty<string>("filterPeriodEnd");
            }
        }
        
        public ReadStatus FilterReadStatus
        {
            get
            {
                return this.GetProperty<ReadStatus>("filterReadStatus");
            }
        }
        
        public string FilterRecipient
        {
            get
            {
                return this.GetProperty<string>("filterRecipient");
            }
        }
        
        public string FilterOriginator
        {
            get
            {
                return this.GetProperty<string>("filterOriginator");
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
