namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMDownloadManager : WebIDLBase
    {
        
        public DOMDownloadManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetDownloads()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getDownloads");
        }
        
        public Promise < nsISupports > Remove(nsISupports download)
        {
            return this.CallMethod<Promise < nsISupports >>("remove", download);
        }
        
        public void ClearAllDone()
        {
            this.CallVoidMethod("clearAllDone");
        }
        
        public Promise < nsISupports > AdoptDownload()
        {
            return this.CallMethod<Promise < nsISupports >>("adoptDownload");
        }
        
        public Promise < nsISupports > AdoptDownload(object download)
        {
            return this.CallMethod<Promise < nsISupports >>("adoptDownload", download);
        }
    }
}
