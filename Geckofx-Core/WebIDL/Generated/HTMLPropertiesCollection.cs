namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLPropertiesCollection : WebIDLBase
    {
        
        public HTMLPropertiesCollection(nsISupports thisObject) : 
                base(thisObject)
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
