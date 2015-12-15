namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorGeolocation : WebIDLBase
    {
        
        public NavigatorGeolocation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Geolocation
        {
            get
            {
                return this.GetProperty<nsISupports>("geolocation");
            }
        }
    }
}
