namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMSettableTokenList : WebIDLBase
    {
        
        public DOMSettableTokenList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Value
        {
            get
            {
                return this.GetProperty<nsAString>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
    }
}
