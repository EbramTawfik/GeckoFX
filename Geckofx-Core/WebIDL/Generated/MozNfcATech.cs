namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNfcATech : WebIDLBase
    {
        
        public MozNfcATech(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < IntPtr > Transceive(IntPtr command)
        {
            return this.CallMethod<Promise < IntPtr >>("transceive", command);
        }
    }
}
