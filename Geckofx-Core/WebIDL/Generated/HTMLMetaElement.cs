namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMetaElement : WebIDLBase
    {
        
        public HTMLMetaElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsAString HttpEquiv
        {
            get
            {
                return this.GetProperty<nsAString>("httpEquiv");
            }
            set
            {
                this.SetProperty("httpEquiv", value);
            }
        }
        
        public nsAString Content
        {
            get
            {
                return this.GetProperty<nsAString>("content");
            }
            set
            {
                this.SetProperty("content", value);
            }
        }
        
        public nsAString Scheme
        {
            get
            {
                return this.GetProperty<nsAString>("scheme");
            }
            set
            {
                this.SetProperty("scheme", value);
            }
        }
    }
}
