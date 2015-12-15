namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHyperlinkElementUtils : WebIDLBase
    {
        
        public HTMLHyperlinkElementUtils(nsISupports thisObject) : 
                base(thisObject)
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
        
        public USVString Username
        {
            get
            {
                return this.GetProperty<USVString>("username");
            }
            set
            {
                this.SetProperty("username", value);
            }
        }
        
        public USVString Password
        {
            get
            {
                return this.GetProperty<USVString>("password");
            }
            set
            {
                this.SetProperty("password", value);
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
    }
}
