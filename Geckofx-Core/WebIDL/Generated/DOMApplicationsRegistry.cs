namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMApplicationsRegistry : WebIDLBase
    {
        
        public DOMApplicationsRegistry(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Mgmt
        {
            get
            {
                return this.GetProperty<nsISupports>("mgmt");
            }
        }
        
        public nsISupports Install(nsAString url)
        {
            return this.CallMethod<nsISupports>("install", url);
        }
        
        public nsISupports Install(nsAString url, object @params)
        {
            return this.CallMethod<nsISupports>("install", url, @params);
        }
        
        public nsISupports InstallPackage(nsAString url)
        {
            return this.CallMethod<nsISupports>("installPackage", url);
        }
        
        public nsISupports InstallPackage(nsAString url, object @params)
        {
            return this.CallMethod<nsISupports>("installPackage", url, @params);
        }
        
        public nsISupports GetSelf()
        {
            return this.CallMethod<nsISupports>("getSelf");
        }
        
        public nsISupports GetInstalled()
        {
            return this.CallMethod<nsISupports>("getInstalled");
        }
        
        public nsISupports CheckInstalled(nsAString manifestUrl)
        {
            return this.CallMethod<nsISupports>("checkInstalled", manifestUrl);
        }
        
        public Promise < MozMap < System.Object[] >> GetAdditionalLanguages()
        {
            return this.CallMethod<Promise < MozMap < System.Object[] >>>("getAdditionalLanguages");
        }
        
        public Promise <object> GetLocalizationResource(nsAString language, nsAString version, nsAString path, LocaleResourceType dataType)
        {
            return this.CallMethod<Promise <object>>("getLocalizationResource", language, version, path, dataType);
        }
    }
}
