namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMetaElement : WebIDLBase
    {
        
        public HTMLMetaElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public string HttpEquiv
        {
            get
            {
                return this.GetProperty<string>("httpEquiv");
            }
            set
            {
                this.SetProperty("httpEquiv", value);
            }
        }
        
        public string Content
        {
            get
            {
                return this.GetProperty<string>("content");
            }
            set
            {
                this.SetProperty("content", value);
            }
        }
        
        public string Scheme
        {
            get
            {
                return this.GetProperty<string>("scheme");
            }
            set
            {
                this.SetProperty("scheme", value);
            }
        }
    }
}
