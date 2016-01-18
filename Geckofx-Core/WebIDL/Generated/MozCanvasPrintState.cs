namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCanvasPrintState : WebIDLBase
    {
        
        public MozCanvasPrintState(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
