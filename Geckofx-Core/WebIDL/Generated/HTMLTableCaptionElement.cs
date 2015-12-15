namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableCaptionElement : WebIDLBase
    {
        
        public HTMLTableCaptionElement(nsISupports thisObject) : 
                base(thisObject)
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
