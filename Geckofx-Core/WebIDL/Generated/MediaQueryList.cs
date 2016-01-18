namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaQueryList : WebIDLBase
    {
        
        public MediaQueryList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Media
        {
            get
            {
                return this.GetProperty<string>("media");
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
