namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLLabelElement : WebIDLBase
    {
        
        public HTMLLabelElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Form
        {
            get
            {
                return this.GetProperty<nsISupports>("form");
            }
        }
        
        public nsAString HtmlFor
        {
            get
            {
                return this.GetProperty<nsAString>("htmlFor");
            }
            set
            {
                this.SetProperty("htmlFor", value);
            }
        }
        
        public nsISupports Control
        {
            get
            {
                return this.GetProperty<nsISupports>("control");
            }
        }
    }
}
