namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextEncoder : WebIDLBase
    {
        
        public TextEncoder(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Encoding
        {
            get
            {
                return this.GetProperty<nsAString>("encoding");
            }
        }
        
        public IntPtr Encode()
        {
            return this.CallMethod<IntPtr>("encode");
        }
        
        public IntPtr Encode(USVString input)
        {
            return this.CallMethod<IntPtr>("encode", input);
        }
    }
}
