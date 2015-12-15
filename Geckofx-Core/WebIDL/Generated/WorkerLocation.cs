namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerLocation : WebIDLBase
    {
        
        public WorkerLocation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public USVString Href
        {
            get
            {
                return this.GetProperty<USVString>("href");
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
        }
        
        public USVString Host
        {
            get
            {
                return this.GetProperty<USVString>("host");
            }
        }
        
        public USVString Hostname
        {
            get
            {
                return this.GetProperty<USVString>("hostname");
            }
        }
        
        public USVString Port
        {
            get
            {
                return this.GetProperty<USVString>("port");
            }
        }
        
        public USVString Pathname
        {
            get
            {
                return this.GetProperty<USVString>("pathname");
            }
        }
        
        public USVString Search
        {
            get
            {
                return this.GetProperty<USVString>("search");
            }
        }
        
        public USVString Hash
        {
            get
            {
                return this.GetProperty<USVString>("hash");
            }
        }
    }
}
