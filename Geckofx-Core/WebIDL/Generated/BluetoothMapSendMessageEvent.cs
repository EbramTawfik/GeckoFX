namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapSendMessageEvent : WebIDLBase
    {
        
        public BluetoothMapSendMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Recipient
        {
            get
            {
                return this.GetProperty<nsAString>("recipient");
            }
        }
        
        public nsAString MessageBody
        {
            get
            {
                return this.GetProperty<nsAString>("messageBody");
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
