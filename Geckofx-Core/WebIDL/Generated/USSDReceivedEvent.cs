namespace Gecko.WebIDL
{
    using System;
    
    
    public class USSDReceivedEvent : WebIDLBase
    {
        
        public USSDReceivedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint ServiceId
        {
            get
            {
                return this.GetProperty<uint>("serviceId");
            }
        }
        
        public string Message
        {
            get
            {
                return this.GetProperty<string>("message");
            }
        }
        
        public nsISupports Session
        {
            get
            {
                return this.GetProperty<nsISupports>("session");
            }
        }
    }
}
