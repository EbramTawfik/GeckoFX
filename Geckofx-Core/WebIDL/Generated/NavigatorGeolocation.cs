namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorGeolocation : WebIDLBase
    {
        
        public NavigatorGeolocation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
