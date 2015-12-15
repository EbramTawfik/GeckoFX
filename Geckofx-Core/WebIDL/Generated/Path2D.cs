namespace Gecko.WebIDL
{
    using System;
    
    
    public class Path2D : WebIDLBase
    {
        
        public Path2D(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void AddPath(nsISupports path, nsISupports transformation)
        {
            this.CallVoidMethod("addPath", path, transformation);
        }
    }
}
