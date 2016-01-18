namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTitleElement : WebIDLBase
    {
        
        public HTMLTitleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Text
        {
            get
            {
                return this.GetProperty<string>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
    }
}
