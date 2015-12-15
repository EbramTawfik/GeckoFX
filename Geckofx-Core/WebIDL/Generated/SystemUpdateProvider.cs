namespace Gecko.WebIDL
{
    using System;
    
    
    public class SystemUpdateProvider : WebIDLBase
    {
        
        public SystemUpdateProvider(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString Uuid
        {
            get
            {
                return this.GetProperty<nsAString>("uuid");
            }
        }
        
        public void CheckForUpdate()
        {
            this.CallVoidMethod("checkForUpdate");
        }
        
        public void StartDownload()
        {
            this.CallVoidMethod("startDownload");
        }
        
        public void StopDownload()
        {
            this.CallVoidMethod("stopDownload");
        }
        
        public void ApplyUpdate()
        {
            this.CallVoidMethod("applyUpdate");
        }
        
        public bool SetParameter(nsAString name, nsAString value)
        {
            return this.CallMethod<bool>("setParameter", name, value);
        }
        
        public nsAString GetParameter(nsAString name)
        {
            return this.CallMethod<nsAString>("getParameter", name);
        }
    }
}
