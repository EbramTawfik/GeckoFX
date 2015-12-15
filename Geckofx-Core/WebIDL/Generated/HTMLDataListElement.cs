namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDataListElement : WebIDLBase
    {
        
        public HTMLDataListElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Options
        {
            get
            {
                return this.GetProperty<nsISupports>("options");
            }
        }
    }
}
