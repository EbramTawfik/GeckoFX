namespace Gecko.WebIDL
{
    using System;
    
    
    public class DesktopNotificationCenter : WebIDLBase
    {
        
        public DesktopNotificationCenter(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports CreateNotification(nsAString title, nsAString description, nsAString iconURL)
        {
            return this.CallMethod<nsISupports>("createNotification", title, description, iconURL);
        }
    }
}
