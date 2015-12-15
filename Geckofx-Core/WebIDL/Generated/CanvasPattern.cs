namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasPattern : WebIDLBase
    {
        
        public CanvasPattern(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void SetTransform(nsISupports matrix)
        {
            this.CallVoidMethod("setTransform", matrix);
        }
    }
}
