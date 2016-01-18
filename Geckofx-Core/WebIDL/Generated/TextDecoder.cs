namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextDecoder : WebIDLBase
    {
        
        public TextDecoder(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool Fatal
        {
            get
            {
                return this.GetProperty<bool>("fatal");
            }
        }
        
        public USVString Decode()
        {
            return this.CallMethod<USVString>("decode");
        }
        
        public USVString Decode(IntPtr input)
        {
            return this.CallMethod<USVString>("decode", input);
        }
        
        public USVString Decode(IntPtr input, object options)
        {
            return this.CallMethod<USVString>("decode", input, options);
        }
    }
}
