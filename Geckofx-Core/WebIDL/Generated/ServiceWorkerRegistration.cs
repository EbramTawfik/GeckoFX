namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerRegistration : WebIDLBase
    {
        
        public ServiceWorkerRegistration(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise ShowNotification(nsAString title)
        {
            return this.CallMethod<Promise>("showNotification", title);
        }
        
        public Promise ShowNotification(nsAString title, object options)
        {
            return this.CallMethod<Promise>("showNotification", title, options);
        }
        
        public Promise < nsISupports[] > GetNotifications()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getNotifications");
        }
        
        public Promise < nsISupports[] > GetNotifications(object filter)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getNotifications", filter);
        }
        
        public nsISupports Installing
        {
            get
            {
                return this.GetProperty<nsISupports>("installing");
            }
        }
        
        public nsISupports Waiting
        {
            get
            {
                return this.GetProperty<nsISupports>("waiting");
            }
        }
        
        public nsISupports Active
        {
            get
            {
                return this.GetProperty<nsISupports>("active");
            }
        }
        
        public USVString Scope
        {
            get
            {
                return this.GetProperty<USVString>("scope");
            }
        }
        
        public Promise Update()
        {
            return this.CallMethod<Promise>("update");
        }
        
        public Promise <bool> Unregister()
        {
            return this.CallMethod<Promise <bool>>("unregister");
        }
    }
}
