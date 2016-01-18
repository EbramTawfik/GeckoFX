namespace Gecko.WebIDL
{
    using System;
    
    
    public class LocalMediaStream : WebIDLBase
    {
        
        public LocalMediaStream(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
    }
}
