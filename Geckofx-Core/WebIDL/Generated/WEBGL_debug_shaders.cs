namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_debug_shaders : WebIDLBase
    {
        
        public WEBGL_debug_shaders(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString GetTranslatedShaderSource(nsISupports shader)
        {
            return this.CallMethod<nsAString>("getTranslatedShaderSource", shader);
        }
    }
}
