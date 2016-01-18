namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHeadingElement : WebIDLBase
    {
        
        public HTMLHeadingElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
