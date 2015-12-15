namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextDecoder : WebIDLBase
    {
        
        public TextDecoder(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Encoding
        {
            get
            {
                return this.GetProperty<nsAString>("encoding");
            }
        }
        
        public bool Fatal
        {
            get
            {
                return this.GetProperty<bool>("fatal");
            }
        }
        
        public USVString Decode(IntPtr input, object options)
        {
            return this.CallMethod<USVString>("decode", input, options);
        }
    }
}
