namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_debug_shaders : WebIDLBase
    {
        
        public WEBGL_debug_shaders(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString GetTranslatedShaderSource(nsISupports shader)
        {
            return this.CallMethod<nsAString>("getTranslatedShaderSource", shader);
        }
    }
}
