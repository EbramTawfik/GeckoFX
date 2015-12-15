namespace Gecko.WebIDL
{
    using System;
    
    
    public class FocusEvent : WebIDLBase
    {
        
        public FocusEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports RelatedTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("relatedTarget");
            }
        }
    }
}
