namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasGradient : WebIDLBase
    {
        
        public CanvasGradient(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddColorStop(float offset, nsAString color)
        {
            this.CallVoidMethod("addColorStop", offset, color);
        }
    }
}
