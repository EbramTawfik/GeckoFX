namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapSendMessageEvent : WebIDLBase
    {
        
        public BluetoothMapSendMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Recipient
        {
            get
            {
                return this.GetProperty<string>("recipient");
            }
        }
        
        public string MessageBody
        {
            get
            {
                return this.GetProperty<string>("messageBody");
            }
        }
        
        public uint Retry
        {
            get
            {
                return this.GetProperty<uint>("retry");
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
