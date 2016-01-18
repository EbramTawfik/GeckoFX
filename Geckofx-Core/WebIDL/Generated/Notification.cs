namespace Gecko.WebIDL
{
    using System;
    
    
    public class Notification : WebIDLBase
    {
        
        public Notification(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public NotificationPermission Permission
        {
            get
            {
                return this.GetProperty<NotificationPermission>("permission");
            }
            set
            {
                this.SetProperty("permission", value);
            }
        }
        
        public nsAString Title
        {
            get
            {
                return this.GetProperty<nsAString>("title");
            }
        }
        
        public NotificationDirection Dir
        {
            get
            {
                return this.GetProperty<NotificationDirection>("dir");
            }
        }
        
        public nsAString Lang
        {
            get
            {
                return this.GetProperty<nsAString>("lang");
            }
        }
        
        public nsAString Body
        {
            get
            {
                return this.GetProperty<nsAString>("body");
            }
        }
        
        public nsAString Tag
        {
            get
            {
                return this.GetProperty<nsAString>("tag");
            }
        }
        
        public nsAString Icon
        {
            get
            {
                return this.GetProperty<nsAString>("icon");
            }
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
