namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventSource : WebIDLBase
    {
        
        public EventSource(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
            }
        }
        
        public bool WithCredentials
        {
            get
            {
                return this.GetProperty<bool>("withCredentials");
            }
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
