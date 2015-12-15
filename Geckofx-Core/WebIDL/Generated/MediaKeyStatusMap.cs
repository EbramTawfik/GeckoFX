namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyStatusMap : WebIDLBase
    {
        
        public MediaKeyStatusMap(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
        }
        
        public bool Has(IntPtr keyId)
        {
            return this.CallMethod<bool>("has", keyId);
        }
        
        public MediaKeyStatus Get(IntPtr keyId)
        {
            return this.CallMethod<MediaKeyStatus>("get", keyId);
        }
    }
}
