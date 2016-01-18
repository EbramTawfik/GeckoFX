namespace Gecko.WebIDL
{
    using System;
    
    
    public class Location : WebIDLBase
    {
        
        public Location(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Href
        {
            get
            {
                return this.GetProperty<USVString>("href");
            }
            set
            {
                this.SetProperty("href", value);
            }
        }
        
        public USVString Origin
        {
            get
            {
                return this.GetProperty<USVString>("origin");
            }
        }
        
        public USVString Protocol
        {
            get
            {
                return this.GetProperty<USVString>("protocol");
            }
            set
            {
                this.SetProperty("protocol", value);
            }
        }
        
        public USVString Host
        {
            get
            {
                return this.GetProperty<USVString>("host");
            }
            set
            {
                this.SetProperty("host", value);
            }
        }
        
        public USVString Hostname
        {
            get
            {
                return this.GetProperty<USVString>("hostname");
            }
            set
            {
                this.SetProperty("hostname", value);
            }
        }
        
        public USVString Port
        {
            get
            {
                return this.GetProperty<USVString>("port");
            }
            set
            {
                this.SetProperty("port", value);
            }
        }
        
        public USVString Pathname
        {
            get
            {
                return this.GetProperty<USVString>("pathname");
            }
            set
            {
                this.SetProperty("pathname", value);
            }
        }
        
        public USVString Search
        {
            get
            {
                return this.GetProperty<USVString>("search");
            }
            set
            {
                this.SetProperty("search", value);
            }
        }
        
        public USVString Hash
        {
            get
            {
                return this.GetProperty<USVString>("hash");
            }
            set
            {
                this.SetProperty("hash", value);
            }
        }
        
        public void Assign(USVString url)
        {
            this.CallVoidMethod("assign", url);
        }
        
        public void Replace(USVString url)
        {
            this.CallVoidMethod("replace", url);
        }
        
        public void Reload()
        {
            this.CallVoidMethod("reload");
        }
        
        public void Reload(bool forceget)
        {
            this.CallVoidMethod("reload", forceget);
        }
    }
}
