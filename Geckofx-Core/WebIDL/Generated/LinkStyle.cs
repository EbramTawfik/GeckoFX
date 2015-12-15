namespace Gecko.WebIDL
{
    using System;
    
    
    public class LinkStyle : WebIDLBase
    {
        
        public LinkStyle(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Sheet
        {
            get
            {
                return this.GetProperty<nsISupports>("sheet");
            }
        }
    }
}
