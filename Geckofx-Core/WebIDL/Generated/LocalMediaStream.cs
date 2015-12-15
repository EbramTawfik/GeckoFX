namespace Gecko.WebIDL
{
    using System;
    
    
    public class LocalMediaStream : WebIDLBase
    {
        
        public LocalMediaStream(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
    }
}
