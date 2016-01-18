namespace Gecko.WebIDL
{
    using System;
    
    
    public class ExtendableMessageEvent : WebIDLBase
    {
        
        public ExtendableMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public string Origin
        {
            get
            {
                return this.GetProperty<string>("origin");
            }
        }
        
        public string LastEventId
        {
            get
            {
                return this.GetProperty<string>("lastEventId");
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports Ports
        {
            get
            {
                return this.GetProperty<nsISupports>("ports");
            }
        }
    }
}
