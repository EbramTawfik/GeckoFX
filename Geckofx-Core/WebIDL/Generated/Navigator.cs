namespace Gecko.WebIDL
{
    using System;
    
    
    public class Navigator : WebIDLBase
    {
        
        public Navigator(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Permissions
        {
            get
            {
                return this.GetProperty<nsISupports>("permissions");
            }
        }
        
        public nsISupports MimeTypes
        {
            get
            {
                return this.GetProperty<nsISupports>("mimeTypes");
            }
        }
        
        public nsISupports Plugins
        {
            get
            {
                return this.GetProperty<nsISupports>("plugins");
            }
        }
        
        public string DoNotTrack
        {
            get
            {
                return this.GetProperty<string>("doNotTrack");
            }
        }
        
        public nsISupports Battery
        {
            get
            {
                return this.GetProperty<nsISupports>("battery");
            }
        }
        
        public Promise < nsISupports > GetBattery()
        {
            return this.CallMethod<Promise < nsISupports >>("getBattery");
        }
        
        public bool Vibrate(uint duration)
        {
            return this.CallMethod<bool>("vibrate", duration);
        }
        
        public bool Vibrate(uint[] pattern)
        {
            return this.CallMethod<bool>("vibrate", pattern);
        }
        
        public int MaxTouchPoints
        {
            get
            {
                return this.GetProperty<int>("maxTouchPoints");
            }
        }
        
        public string Oscpu
        {
            get
            {
                return this.GetProperty<string>("oscpu");
            }
        }
        
        public string Vendor
        {
            get
            {
                return this.GetProperty<string>("vendor");
            }
        }
        
        public string VendorSub
        {
            get
            {
                return this.GetProperty<string>("vendorSub");
            }
        }
        
        public string ProductSub
        {
            get
            {
                return this.GetProperty<string>("productSub");
            }
        }
        
        public bool CookieEnabled
        {
            get
            {
                return this.GetProperty<bool>("cookieEnabled");
            }
        }
        
        public string BuildID
        {
            get
            {
                return this.GetProperty<string>("buildID");
            }
        }
        
        public nsISupports MozPower
        {
            get
            {
                return this.GetProperty<nsISupports>("mozPower");
            }
        }
        
        public bool JavaEnabled()
        {
            return this.CallMethod<bool>("javaEnabled");
        }
        
        public void AddIdleObserver(nsISupports aIdleObserver)
        {
            this.CallVoidMethod("addIdleObserver", aIdleObserver);
        }
        
        public void RemoveIdleObserver(nsISupports aIdleObserver)
        {
            this.CallVoidMethod("removeIdleObserver", aIdleObserver);
        }
        
        public nsISupports RequestWakeLock(string aTopic)
        {
            return this.CallMethod<nsISupports>("requestWakeLock", aTopic);
        }
        
        public nsISupports DeviceStorageAreaListener
        {
            get
            {
                return this.GetProperty<nsISupports>("deviceStorageAreaListener");
            }
        }
        
        public nsISupports GetDeviceStorage(string type)
        {
            return this.CallMethod<nsISupports>("getDeviceStorage", type);
        }
        
        public nsISupports[] GetDeviceStorages(string type)
        {
            return this.CallMethod<nsISupports[]>("getDeviceStorages", type);
        }
        
        public nsISupports GetDeviceStorageByNameAndType(string name, string type)
        {
            return this.CallMethod<nsISupports>("getDeviceStorageByNameAndType", name, type);
        }
        
        public nsISupports MozNotification
        {
            get
            {
                return this.GetProperty<nsISupports>("mozNotification");
            }
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
        
        public nsISupports MozCameras
        {
            get
            {
                return this.GetProperty<nsISupports>("mozCameras");
            }
        }
        
        public bool MozHasPendingMessage(string type)
        {
            return this.CallMethod<bool>("mozHasPendingMessage", type);
        }
        
        public void MozSetMessageHandlerPromise(Promise <object> promise)
        {
            this.CallVoidMethod("mozSetMessageHandlerPromise", promise);
        }
        
        public Promise < nsISupports[] > GetVRDevices()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getVRDevices");
        }
        
        public nsISupports ServiceWorker
        {
            get
            {
                return this.GetProperty<nsISupports>("serviceWorker");
            }
        }
        
        public bool SendBeacon(string url)
        {
            return this.CallMethod<bool>("sendBeacon", url);
        }
        
        public bool SendBeacon(string url, WebIDLUnion<IntPtr,nsIDOMBlob,System.String,nsIDOMFormData> data)
        {
            return this.CallMethod<bool>("sendBeacon", url, data);
        }
        
        public nsISupports Tv
        {
            get
            {
                return this.GetProperty<nsISupports>("tv");
            }
        }
        
        public nsISupports InputPortManager
        {
            get
            {
                return this.GetProperty<nsISupports>("inputPortManager");
            }
        }
        
        public nsISupports Presentation
        {
            get
            {
                return this.GetProperty<nsISupports>("presentation");
            }
        }
        
        public nsISupports MozTCPSocket
        {
            get
            {
                return this.GetProperty<nsISupports>("mozTCPSocket");
            }
        }
    }
}
