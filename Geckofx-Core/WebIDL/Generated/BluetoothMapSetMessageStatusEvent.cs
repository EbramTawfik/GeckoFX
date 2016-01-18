namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapSetMessageStatusEvent : WebIDLBase
    {
        
        public BluetoothMapSetMessageStatusEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint HandleId
        {
            get
            {
                return this.GetProperty<uint>("handleId");
            }
        }
        
        public StatusIndicators StatusIndicator
        {
            get
            {
                return this.GetProperty<StatusIndicators>("statusIndicator");
            }
        }
        
        public bool StatusValue
        {
            get
            {
                return this.GetProperty<bool>("statusValue");
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
