namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMDownload : WebIDLBase
    {
        
        public DOMDownload(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public long TotalBytes
        {
            get
            {
                return this.GetProperty<long>("totalBytes");
            }
        }
        
        public long CurrentBytes
        {
            get
            {
                return this.GetProperty<long>("currentBytes");
            }
        }
        
        public nsAString Url
        {
            get
            {
                return this.GetProperty<nsAString>("url");
            }
        }
        
        public nsAString Path
        {
            get
            {
                return this.GetProperty<nsAString>("path");
            }
        }
        
        public nsAString StorageName
        {
            get
            {
                return this.GetProperty<nsAString>("storageName");
            }
        }
        
        public nsAString StoragePath
        {
            get
            {
                return this.GetProperty<nsAString>("storagePath");
            }
        }
        
        public DownloadState State
        {
            get
            {
                return this.GetProperty<DownloadState>("state");
            }
        }
        
        public nsAString ContentType
        {
            get
            {
                return this.GetProperty<nsAString>("contentType");
            }
        }
        
        public IntPtr StartTime
        {
            get
            {
                return this.GetProperty<IntPtr>("startTime");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsAString SourceAppManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("sourceAppManifestURL");
            }
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public Promise < nsISupports > Pause()
        {
            return this.CallMethod<Promise < nsISupports >>("pause");
        }
        
        public Promise < nsISupports > Resume()
        {
            return this.CallMethod<Promise < nsISupports >>("resume");
        }
    }
}
