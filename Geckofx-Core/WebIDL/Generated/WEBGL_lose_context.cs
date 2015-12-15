namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_lose_context : WebIDLBase
    {
        
        public WEBGL_lose_context(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void LoseContext()
        {
            this.CallVoidMethod("loseContext");
        }
        
        public void RestoreContext()
        {
            this.CallVoidMethod("restoreContext");
        }
    }
}
