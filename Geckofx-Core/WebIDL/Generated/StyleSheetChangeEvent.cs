namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheetChangeEvent : WebIDLBase
    {
        
        public StyleSheetChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Stylesheet
        {
            get
            {
                return this.GetProperty<nsISupports>("stylesheet");
            }
        }
        
        public bool DocumentSheet
        {
            get
            {
                return this.GetProperty<bool>("documentSheet");
            }
        }
    }
}
