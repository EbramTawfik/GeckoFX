namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNDEFRecord : WebIDLBase
    {
        
        public MozNDEFRecord(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public TNF Tnf
        {
            get
            {
                return this.GetProperty<TNF>("tnf");
            }
        }
        
        public IntPtr Type
        {
            get
            {
                return this.GetProperty<IntPtr>("type");
            }
        }
        
        public IntPtr Id
        {
            get
            {
                return this.GetProperty<IntPtr>("id");
            }
        }
        
        public IntPtr Payload
        {
            get
            {
                return this.GetProperty<IntPtr>("payload");
            }
        }
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
        }
        
        public nsAString GetAsURI()
        {
            return this.CallMethod<nsAString>("getAsURI");
        }
    }
}
