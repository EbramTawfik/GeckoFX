namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableCaptionElement : WebIDLBase
    {
        
        public HTMLTableCaptionElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
    }
}
