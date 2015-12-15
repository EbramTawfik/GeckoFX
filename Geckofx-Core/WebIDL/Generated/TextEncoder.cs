namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextEncoder : WebIDLBase
    {
        
        public TextEncoder(nsISupports thisObject) : 
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
        
        public IntPtr Encode(USVString input)
        {
            return this.CallMethod<IntPtr>("encode", input);
        }
    }
}
