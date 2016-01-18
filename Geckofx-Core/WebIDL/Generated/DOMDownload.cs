namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMDownload : WebIDLBase
    {
        
        public DOMDownload(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
            }
        }
        
        public string Path
        {
            get
            {
                return this.GetProperty<string>("path");
            }
        }
        
        public string StorageName
        {
            get
            {
                return this.GetProperty<string>("storageName");
            }
        }
        
        public string StoragePath
        {
            get
            {
                return this.GetProperty<string>("storagePath");
            }
        }
        
        public DownloadState State
        {
            get
            {
                return this.GetProperty<DownloadState>("state");
            }
        }
        
        public string ContentType
        {
            get
            {
                return this.GetProperty<string>("contentType");
            }
        }
        
        public IntPtr StartTime
        {
            get
            {
                return this.GetProperty<IntPtr>("startTime");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string SourceAppManifestURL
        {
            get
            {
                return this.GetProperty<string>("sourceAppManifestURL");
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
