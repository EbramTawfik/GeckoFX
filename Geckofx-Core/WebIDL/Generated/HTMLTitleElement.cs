namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTitleElement : WebIDLBase
    {
        
        public HTMLTitleElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
    }
}
