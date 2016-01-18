namespace Gecko.WebIDL
{
    using System;
    
    
    public class SystemUpdateProvider : WebIDLBase
    {
        
        public SystemUpdateProvider(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Uuid
        {
            get
            {
                return this.GetProperty<string>("uuid");
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
        
        public bool SetParameter(string name, string value)
        {
            return this.CallMethod<bool>("setParameter", name, value);
        }
        
        public string GetParameter(string name)
        {
            return this.CallMethod<string>("getParameter", name);
        }
    }
}
