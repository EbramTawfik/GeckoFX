namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventSource : WebIDLBase
    {
        
        public EventSource(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Url
        {
            get
            {
                return this.GetProperty<nsAString>("url");
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
