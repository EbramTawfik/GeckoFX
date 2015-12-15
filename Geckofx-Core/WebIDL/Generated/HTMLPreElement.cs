namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLPreElement : WebIDLBase
    {
        
        public HTMLPreElement(nsISupports thisObject) : 
                base(thisObject)
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
