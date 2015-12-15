namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLLegendElement : WebIDLBase
    {
        
        public HTMLLegendElement(nsISupports thisObject) : 
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
