namespace Gecko.WebIDL
{
    using System;
    
    
    public class Attr : WebIDLBase
    {
        
        public Attr(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString LocalName
        {
            get
            {
                return this.GetProperty<nsAString>("localName");
            }
        }
        
        public nsAString Value
        {
            get
            {
                return this.GetProperty<nsAString>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString NamespaceURI
        {
            get
            {
                return this.GetProperty<nsAString>("namespaceURI");
            }
        }
        
        public nsAString Prefix
        {
            get
            {
                return this.GetProperty<nsAString>("prefix");
            }
        }
        
        public bool Specified
        {
            get
            {
                return this.GetProperty<bool>("specified");
            }
        }
        
        public nsIDOMElement OwnerElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("ownerElement");
            }
        }
    }
}
