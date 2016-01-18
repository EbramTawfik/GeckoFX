namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDivElement : WebIDLBase
    {
        
        public HTMLDivElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
