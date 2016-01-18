namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleRuleChangeEvent : WebIDLBase
    {
        
        public StyleRuleChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Rule
        {
            get
            {
                return this.GetProperty<nsISupports>("rule");
            }
        }
    }
}
