namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLParagraphElement : WebIDLBase
    {
        
        public HTMLParagraphElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
    }
}
