namespace Gecko.WebIDL
{
    using System;
    
    
    public class NotificationEvent : WebIDLBase
    {
        
        public NotificationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Notification
        {
            get
            {
                return this.GetProperty<nsISupports>("notification");
            }
        }
    }
}
