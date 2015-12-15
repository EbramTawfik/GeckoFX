namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMApplicationsManager : WebIDLBase
    {
        
        public DOMApplicationsManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetAll()
        {
            return this.CallMethod<nsISupports>("getAll");
        }
        
        public nsISupports GetNotInstalled()
        {
            return this.CallMethod<nsISupports>("getNotInstalled");
        }
        
        public void ApplyDownload(nsISupports app)
        {
            this.CallVoidMethod("applyDownload", app);
        }
        
        public nsISupports Uninstall(nsISupports app)
        {
            return this.CallMethod<nsISupports>("uninstall", app);
        }
        
        public Promise < nsISupports > Import(nsIDOMBlob blob)
        {
            return this.CallMethod<Promise < nsISupports >>("import", blob);
        }
        
        public Promise <object> ExtractManifest(nsIDOMBlob blob)
        {
            return this.CallMethod<Promise <object>>("extractManifest", blob);
        }
        
        public void SetEnabled(nsISupports app, bool state)
        {
            this.CallVoidMethod("setEnabled", app, state);
        }
        
        public Promise < nsIDOMBlob > GetIcon(nsISupports app, nsAString iconID, nsAString entryPoint)
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("getIcon", app, iconID, entryPoint);
        }
    }
}
