namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSValue : WebIDLBase
    {
        
        public CSSValue(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string CssText
        {
            get
            {
                return this.GetProperty<string>("cssText");
            }
            set
            {
                this.SetProperty("cssText", value);
            }
        }
        
        public ushort CssValueType
        {
            get
            {
                return this.GetProperty<ushort>("cssValueType");
            }
        }
    }
}
