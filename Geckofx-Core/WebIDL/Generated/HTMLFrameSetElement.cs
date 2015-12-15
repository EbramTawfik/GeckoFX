namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFrameSetElement : WebIDLBase
    {
        
        public HTMLFrameSetElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Cols
        {
            get
            {
                return this.GetProperty<nsAString>("cols");
            }
            set
            {
                this.SetProperty("cols", value);
            }
        }
        
        public nsAString Rows
        {
            get
            {
                return this.GetProperty<nsAString>("rows");
            }
            set
            {
                this.SetProperty("rows", value);
            }
        }
    }
}
