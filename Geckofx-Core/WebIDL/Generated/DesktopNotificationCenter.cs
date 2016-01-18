namespace Gecko.WebIDL
{
    using System;
    
    
    public class DesktopNotificationCenter : WebIDLBase
    {
        
        public DesktopNotificationCenter(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateNotification(string title, string description)
        {
            return this.CallMethod<nsISupports>("createNotification", title, description);
        }
        
        public nsISupports CreateNotification(string title, string description, string iconURL)
        {
            return this.CallMethod<nsISupports>("createNotification", title, description, iconURL);
        }
    }
}
