namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMApplication : WebIDLBase
    {
        
        public DOMApplication(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Manifest
        {
            get
            {
                return this.GetProperty<object>("manifest");
            }
        }
        
        public object UpdateManifest
        {
            get
            {
                return this.GetProperty<object>("updateManifest");
            }
        }
        
        public nsAString ManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("manifestURL");
            }
        }
        
        public nsAString Origin
        {
            get
            {
                return this.GetProperty<nsAString>("origin");
            }
        }
        
        public nsAString InstallOrigin
        {
            get
            {
                return this.GetProperty<nsAString>("installOrigin");
            }
        }
        
        public nsISupports InstallTime
        {
            get
            {
                return this.GetProperty<nsISupports>("installTime");
            }
        }
        
        public bool Removable
        {
            get
            {
                return this.GetProperty<bool>("removable");
            }
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
        }
        
        public nsAString[] Receipts
        {
            get
            {
                return this.GetProperty<nsAString[]>("receipts");
            }
        }
        
        public double Progress
        {
            get
            {
                return this.GetProperty<double>("progress");
            }
        }
        
        public nsAString InstallState
        {
            get
            {
                return this.GetProperty<nsAString>("installState");
            }
        }
        
        public nsISupports LastUpdateCheck
        {
            get
            {
                return this.GetProperty<nsISupports>("lastUpdateCheck");
            }
        }
        
        public nsISupports UpdateTime
        {
            get
            {
                return this.GetProperty<nsISupports>("updateTime");
            }
        }
        
        public bool DownloadAvailable
        {
            get
            {
                return this.GetProperty<bool>("downloadAvailable");
            }
        }
        
        public bool Downloading
        {
            get
            {
                return this.GetProperty<bool>("downloading");
            }
        }
        
        public bool ReadyToApplyDownload
        {
            get
            {
                return this.GetProperty<bool>("readyToApplyDownload");
            }
        }
        
        public int DownloadSize
        {
            get
            {
                return this.GetProperty<int>("downloadSize");
            }
        }
        
        public nsISupports DownloadError
        {
            get
            {
                return this.GetProperty<nsISupports>("downloadError");
            }
        }
        
        public void Download()
        {
            this.CallVoidMethod("download");
        }
        
        public void CancelDownload()
        {
            this.CallVoidMethod("cancelDownload");
        }
        
        public nsISupports Launch()
        {
            return this.CallMethod<nsISupports>("launch");
        }
        
        public nsISupports Launch(nsAString url)
        {
            return this.CallMethod<nsISupports>("launch", url);
        }
        
        public nsISupports ClearBrowserData()
        {
            return this.CallMethod<nsISupports>("clearBrowserData");
        }
        
        public nsISupports CheckForUpdate()
        {
            return this.CallMethod<nsISupports>("checkForUpdate");
        }
        
        public Promise < nsISupports > Connect(nsAString keyword)
        {
            return this.CallMethod<Promise < nsISupports >>("connect", keyword);
        }
        
        public Promise < nsISupports > Connect(nsAString keyword, object rules)
        {
            return this.CallMethod<Promise < nsISupports >>("connect", keyword, rules);
        }
        
        public Promise < nsISupports[] > GetConnections()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getConnections");
        }
        
        public nsISupports AddReceipt()
        {
            return this.CallMethod<nsISupports>("addReceipt");
        }
        
        public nsISupports AddReceipt(nsAString receipt)
        {
            return this.CallMethod<nsISupports>("addReceipt", receipt);
        }
        
        public nsISupports RemoveReceipt()
        {
            return this.CallMethod<nsISupports>("removeReceipt");
        }
        
        public nsISupports RemoveReceipt(nsAString receipt)
        {
            return this.CallMethod<nsISupports>("removeReceipt", receipt);
        }
        
        public nsISupports ReplaceReceipt()
        {
            return this.CallMethod<nsISupports>("replaceReceipt");
        }
        
        public nsISupports ReplaceReceipt(nsAString oldReceipt)
        {
            return this.CallMethod<nsISupports>("replaceReceipt", oldReceipt);
        }
        
        public nsISupports ReplaceReceipt(nsAString oldReceipt, nsAString newReceipt)
        {
            return this.CallMethod<nsISupports>("replaceReceipt", oldReceipt, newReceipt);
        }
        
        public Promise < nsIDOMBlob > Export()
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("export");
        }
        
        public Promise < nsAString > GetLocalizedValue(nsAString property, nsAString locale)
        {
            return this.CallMethod<Promise < nsAString >>("getLocalizedValue", property, locale);
        }
        
        public Promise < nsAString > GetLocalizedValue(nsAString property, nsAString locale, nsAString entryPoint)
        {
            return this.CallMethod<Promise < nsAString >>("getLocalizedValue", property, locale, entryPoint);
        }
    }
}
