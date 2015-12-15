namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheet : WebIDLBase
    {
        
        public StyleSheet(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public nsAString Href
        {
            get
            {
                return this.GetProperty<nsAString>("href");
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
        
        public nsAString Title
        {
            get
            {
                return this.GetProperty<nsAString>("title");
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
