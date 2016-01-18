namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextDecoder : WebIDLBase
    {
        
        public TextDecoder(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Encoding
        {
            get
            {
                return this.GetProperty<string>("encoding");
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
