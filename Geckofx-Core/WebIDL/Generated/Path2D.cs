namespace Gecko.WebIDL
{
    using System;
    
    
    public class Path2D : WebIDLBase
    {
        
        public Path2D(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddPath(nsISupports path)
        {
            this.CallVoidMethod("addPath", path);
        }
        
        public void AddPath(nsISupports path, nsISupports transformation)
        {
            this.CallVoidMethod("addPath", path, transformation);
        }
    }
}
