namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessageEvent : WebIDLBase
    {
        
        public MessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public WebIDLUnion<nsIDOMWindow,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsIDOMWindow,nsISupports>>("source");
            }
        }
        
        public nsISupports Ports
        {
            get
            {
                return this.GetProperty<nsISupports>("ports");
            }
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId, WebIDLUnion<nsIDOMWindow,nsISupports> source, nsISupports[] ports)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId, source, ports);
        }
    }
}
