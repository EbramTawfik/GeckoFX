namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessageEvent : WebIDLBase
    {
        
        public MessageEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public nsAString Origin
        {
            get
            {
                return this.GetProperty<nsAString>("origin");
            }
        }
        
        public nsAString LastEventId
        {
            get
            {
                return this.GetProperty<nsAString>("lastEventId");
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
        
        public void InitMessageEvent(nsAString type, bool bubbles, bool cancelable, object data, nsAString origin, nsAString lastEventId, WebIDLUnion<nsIDOMWindow,nsISupports> source, nsISupports[] ports)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId, source, ports);
        }
    }
}
