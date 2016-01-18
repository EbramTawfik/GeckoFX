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
        
        public string Title
        {
            get
            {
                return this.GetProperty<string>("title");
            }
        }
        
        public NotificationDirection Dir
        {
            get
            {
                return this.GetProperty<NotificationDirection>("dir");
            }
        }
        
        public string Lang
        {
            get
            {
                return this.GetProperty<string>("lang");
            }
        }
        
        public string Body
        {
            get
            {
                return this.GetProperty<string>("body");
            }
        }
        
        public string Tag
        {
            get
            {
                return this.GetProperty<string>("tag");
            }
        }
        
        public string Icon
        {
            get
            {
                return this.GetProperty<string>("icon");
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
