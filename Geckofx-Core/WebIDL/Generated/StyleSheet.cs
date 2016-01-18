namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheet : WebIDLBase
    {
        
        public StyleSheet(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public string Href
        {
            get
            {
                return this.GetProperty<string>("href");
            }
        }
        
        public nsIDOMNode OwnerNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("ownerNode");
            }
        }
        
        public nsISupports ParentStyleSheet
        {
            get
            {
                return this.GetProperty<nsISupports>("parentStyleSheet");
            }
        }
        
        public string Title
        {
            get
            {
                return this.GetProperty<string>("title");
            }
        }
        
        public nsISupports Media
        {
            get
            {
                return this.GetProperty<nsISupports>("media");
            }
        }
        
        public bool Disabled
        {
            get
            {
                return this.GetProperty<bool>("disabled");
            }
            set
            {
                this.SetProperty("disabled", value);
            }
        }
    }
}
