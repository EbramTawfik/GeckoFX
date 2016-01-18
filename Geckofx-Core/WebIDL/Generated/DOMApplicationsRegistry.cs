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
        
        public nsISupports Install(string url)
        {
            return this.CallMethod<nsISupports>("install", url);
        }
        
        public nsISupports Install(string url, object @params)
        {
            return this.CallMethod<nsISupports>("install", url, @params);
        }
        
        public nsISupports InstallPackage(string url)
        {
            return this.CallMethod<nsISupports>("installPackage", url);
        }
        
        public nsISupports InstallPackage(string url, object @params)
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
        
        public nsISupports CheckInstalled(string manifestUrl)
        {
            return this.CallMethod<nsISupports>("checkInstalled", manifestUrl);
        }
        
        public Promise < MozMap < System.Object[] >> GetAdditionalLanguages()
        {
            return this.CallMethod<Promise < MozMap < System.Object[] >>>("getAdditionalLanguages");
        }
        
        public Promise <object> GetLocalizationResource(string language, string version, string path, LocaleResourceType dataType)
        {
            return this.CallMethod<Promise <object>>("getLocalizationResource", language, version, path, dataType);
        }
    }
}
