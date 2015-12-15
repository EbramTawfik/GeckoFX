namespace Gecko.WebIDL
{
    using System;
    
    
    public class Client : WebIDLBase
    {
        
        public Client(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public USVString Url
        {
            get
            {
                return this.GetProperty<USVString>("url");
            }
        }
        
        public FrameType FrameType
        {
            get
            {
                return this.GetProperty<FrameType>("frameType");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public void PostMessage(object message, Object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
    }
}
