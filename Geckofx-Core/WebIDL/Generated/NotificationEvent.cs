namespace Gecko.WebIDL
{
    using System;
    
    
    public class NotificationEvent : WebIDLBase
    {
        
        public NotificationEvent(nsISupports thisObject) : 
                base(thisObject)
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
