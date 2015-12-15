namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCanvasPrintState : WebIDLBase
    {
        
        public MozCanvasPrintState(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Context
        {
            get
            {
                return this.GetProperty<nsISupports>("context");
            }
        }
        
        public void Done()
        {
            this.CallVoidMethod("done");
        }
    }
}
