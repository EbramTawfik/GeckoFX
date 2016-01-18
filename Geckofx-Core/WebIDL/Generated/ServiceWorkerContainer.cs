namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerContainer : WebIDLBase
    {
        
        public ServiceWorkerContainer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Controller
        {
            get
            {
                return this.GetProperty<nsISupports>("controller");
            }
        }
        
        public Promise < nsISupports > Ready
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("ready");
            }
        }
        
        public Promise < nsISupports > Register(USVString scriptURL)
        {
            return this.CallMethod<Promise < nsISupports >>("register", scriptURL);
        }
        
        public Promise < nsISupports > Register(USVString scriptURL, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("register", scriptURL, options);
        }
        
        public Promise < nsISupports > GetRegistration()
        {
            return this.CallMethod<Promise < nsISupports >>("getRegistration");
        }
        
        public Promise < nsISupports > GetRegistration(USVString documentURL)
        {
            return this.CallMethod<Promise < nsISupports >>("getRegistration", documentURL);
        }
        
        public Promise < nsISupports[] > GetRegistrations()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getRegistrations");
        }
        
        public nsAString GetScopeForUrl(nsAString url)
        {
            return this.CallMethod<nsAString>("getScopeForUrl", url);
        }
    }
}
