namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaQueryList : WebIDLBase
    {
        
        public MediaQueryList(nsISupports thisObject) : 
                base(thisObject)
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
