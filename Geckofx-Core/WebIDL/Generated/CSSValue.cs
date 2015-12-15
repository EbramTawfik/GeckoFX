namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSValue : WebIDLBase
    {
        
        public CSSValue(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString CssText
        {
            get
            {
                return this.GetProperty<nsAString>("cssText");
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
