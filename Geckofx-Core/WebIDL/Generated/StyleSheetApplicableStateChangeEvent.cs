namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheetApplicableStateChangeEvent : WebIDLBase
    {
        
        public StyleSheetApplicableStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Stylesheet
        {
            get
            {
                return this.GetProperty<nsISupports>("stylesheet");
            }
        }
        
        public bool Applicable
        {
            get
            {
                return this.GetProperty<bool>("applicable");
            }
        }
    }
}
