namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIsoDepTech : WebIDLBase
    {
        
        public MozIsoDepTech(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < IntPtr > Transceive(IntPtr command)
        {
            return this.CallMethod<Promise < IntPtr >>("transceive", command);
        }
    }
}
