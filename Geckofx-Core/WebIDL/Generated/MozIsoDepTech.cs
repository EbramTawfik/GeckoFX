namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIsoDepTech : WebIDLBase
    {
        
        public MozIsoDepTech(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < IntPtr > Transceive(IntPtr command)
        {
            return this.CallMethod<Promise < IntPtr >>("transceive", command);
        }
    }
}
