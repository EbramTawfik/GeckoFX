namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaDevices : WebIDLBase
    {
        
        public MediaDevices(nsISupports thisObject) : 
                base(thisObject)
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
        
        public Promise < nsISupports > GetUserMedia(object constraints)
        {
            return this.CallMethod<Promise < nsISupports >>("getUserMedia", constraints);
        }
    }
}
