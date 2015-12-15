namespace Gecko.WebIDL
{
    using System;
    
    
    public class Geolocation : WebIDLBase
    {
        
        public Geolocation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void ClearWatch(int watchId)
        {
            this.CallVoidMethod("clearWatch", watchId);
        }
    }
}
