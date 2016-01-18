namespace Gecko.WebIDL
{
    using System;
    
    
    public class Attr : WebIDLBase
    {
        
        public Attr(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string LocalName
        {
            get
            {
                return this.GetProperty<string>("localName");
            }
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string NamespaceURI
        {
            get
            {
                return this.GetProperty<string>("namespaceURI");
            }
        }
        
        public string Prefix
        {
            get
            {
                return this.GetProperty<string>("prefix");
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
