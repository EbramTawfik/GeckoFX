namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_debug_shaders : WebIDLBase
    {
        
        public WEBGL_debug_shaders(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string GetTranslatedShaderSource(nsISupports shader)
        {
            return this.CallMethod<string>("getTranslatedShaderSource", shader);
        }
    }
}
