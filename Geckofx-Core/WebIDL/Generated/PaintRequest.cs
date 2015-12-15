namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaintRequest : WebIDLBase
    {
        
        public PaintRequest(nsISupports thisObject) : 
                base(thisObject)
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
