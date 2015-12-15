namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNfcATech : WebIDLBase
    {
        
        public MozNfcATech(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < IntPtr > Transceive(IntPtr command)
        {
            return this.CallMethod<Promise < IntPtr >>("transceive", command);
        }
    }
}
