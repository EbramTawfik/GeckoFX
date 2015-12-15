namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLParagraphElement : WebIDLBase
    {
        
        public HTMLParagraphElement(nsISupports thisObject) : 
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
