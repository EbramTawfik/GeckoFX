namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapGetMessageEvent : WebIDLBase
    {
        
        public BluetoothMapGetMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HasAttachment
        {
            get
            {
                return this.GetProperty<bool>("hasAttachment");
            }
        }
        
        public FilterCharset Charset
        {
            get
            {
                return this.GetProperty<FilterCharset>("charset");
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
