namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaQueryList : WebIDLBase
    {
        
        public MediaQueryList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Media
        {
            get
            {
                return this.GetProperty<nsAString>("media");
            }
        }
        
        public bool Matches
        {
            get
            {
                return this.GetProperty<bool>("matches");
            }
        }
    }
}
