namespace Gecko.WebIDL
{
    using System;
    
    
    public class OfflineAudioContext : WebIDLBase
    {
        
        public OfflineAudioContext(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > StartRendering()
        {
            return this.CallMethod<Promise < nsISupports >>("startRendering");
        }
    }
}
