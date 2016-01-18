namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLPreElement : WebIDLBase
    {
        
        public HTMLPreElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
    }
}
