namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLPropertiesCollection : WebIDLBase
    {
        
        public HTMLPropertiesCollection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Names
        {
            get
            {
                return this.GetProperty<nsISupports>("names");
            }
        }
    }
}
