namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMCursor : WebIDLBase
    {
        
        public DOMCursor(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Done
        {
            get
            {
                return this.GetProperty<bool>("done");
            }
        }
        
        public void Continue()
        {
            this.CallVoidMethod("continue");
        }
    }
}
