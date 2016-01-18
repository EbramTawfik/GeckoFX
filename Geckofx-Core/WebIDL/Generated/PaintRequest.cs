namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaintRequest : WebIDLBase
    {
        
        public PaintRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("clientRect");
            }
        }
        
        public nsAString Reason
        {
            get
            {
                return this.GetProperty<nsAString>("reason");
            }
        }
    }
}
