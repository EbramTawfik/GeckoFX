namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasGradient : WebIDLBase
    {
        
        public CanvasGradient(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void AddColorStop(float offset, nsAString color)
        {
            this.CallVoidMethod("addColorStop", offset, color);
        }
    }
}
