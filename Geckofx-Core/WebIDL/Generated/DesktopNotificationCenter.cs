namespace Gecko.WebIDL
{
    using System;
    
    
    public class DesktopNotificationCenter : WebIDLBase
    {
        
        public DesktopNotificationCenter(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateNotification(nsAString title, nsAString description)
        {
            return this.CallMethod<nsISupports>("createNotification", title, description);
        }
        
        public nsISupports CreateNotification(nsAString title, nsAString description, nsAString iconURL)
        {
            return this.CallMethod<nsISupports>("createNotification", title, description, iconURL);
        }
    }
}
