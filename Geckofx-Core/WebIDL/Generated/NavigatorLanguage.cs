namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorLanguage : WebIDLBase
    {
        
        public NavigatorLanguage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Language
        {
            get
            {
                return this.GetProperty<nsAString>("language");
            }
        }
        
        public nsAString[] Languages
        {
            get
            {
                return this.GetProperty<nsAString[]>("languages");
            }
        }
    }
}
