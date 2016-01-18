namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaDevices : WebIDLBase
    {
        
        public MediaDevices(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object GetSupportedConstraints()
        {
            return this.CallMethod<object>("getSupportedConstraints");
        }
        
        public Promise < nsISupports[] > EnumerateDevices()
        {
            return this.CallMethod<Promise < nsISupports[] >>("enumerateDevices");
        }
        
        public Promise < nsISupports > GetUserMedia()
        {
            return this.CallMethod<Promise < nsISupports >>("getUserMedia");
        }
        
        public Promise < nsISupports > GetUserMedia(object constraints)
        {
            return this.CallMethod<Promise < nsISupports >>("getUserMedia", constraints);
        }
    }
}
