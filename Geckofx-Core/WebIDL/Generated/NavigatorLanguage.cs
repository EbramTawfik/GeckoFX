namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorLanguage : WebIDLBase
    {
        
        public NavigatorLanguage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Language
        {
            get
            {
                return this.GetProperty<string>("language");
            }
        }
        
        public string[] Languages
        {
            get
            {
                return this.GetProperty<string[]>("languages");
            }
        }
    }
}
