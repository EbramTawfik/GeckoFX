namespace Gecko.WebIDL
{
    using System;
    
    
    public class USSDReceivedEvent : WebIDLBase
    {
        
        public USSDReceivedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint ServiceId
        {
            get
            {
                return this.GetProperty<uint>("serviceId");
            }
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
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
