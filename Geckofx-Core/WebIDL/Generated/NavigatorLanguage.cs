namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorLanguage : WebIDLBase
    {
        
        public NavigatorLanguage(nsISupports thisObject) : 
                base(thisObject)
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
