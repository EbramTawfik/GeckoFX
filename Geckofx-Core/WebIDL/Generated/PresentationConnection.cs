namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnection : WebIDLBase
    {
        
        public PresentationConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public PresentationConnectionState State
        {
            get
            {
                return this.GetProperty<PresentationConnectionState>("state");
            }
        }
        
        public void Send(string data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Terminate()
        {
            this.CallVoidMethod("terminate");
        }
    }
}
