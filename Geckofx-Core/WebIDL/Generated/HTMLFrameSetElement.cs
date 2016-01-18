namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFrameSetElement : WebIDLBase
    {
        
        public HTMLFrameSetElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Cols
        {
            get
            {
                return this.GetProperty<string>("cols");
            }
            set
            {
                this.SetProperty("cols", value);
            }
        }
        
        public string Rows
        {
            get
            {
                return this.GetProperty<string>("rows");
            }
            set
            {
                this.SetProperty("rows", value);
            }
        }
    }
}
