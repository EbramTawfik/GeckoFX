namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSStyleDeclaration : WebIDLBase
    {
        
        public CSSStyleDeclaration(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports ParentRule
        {
            get
            {
                return this.GetProperty<nsISupports>("parentRule");
            }
        }
        
        public nsAString GetPropertyValue(nsAString property)
        {
            return this.CallMethod<nsAString>("getPropertyValue", property);
        }
        
        public nsISupports GetPropertyCSSValue(nsAString property)
        {
            return this.CallMethod<nsISupports>("getPropertyCSSValue", property);
        }
        
        public nsAString GetPropertyPriority(nsAString property)
        {
            return this.CallMethod<nsAString>("getPropertyPriority", property);
        }
        
        public void SetProperty(nsAString property, nsAString value)
        {
            this.CallVoidMethod("setProperty", property, value);
        }
        
        public void SetProperty(nsAString property, nsAString value, nsAString priority)
        {
            this.CallVoidMethod("setProperty", property, value, priority);
        }
        
        public nsAString RemoveProperty(nsAString property)
        {
            return this.CallMethod<nsAString>("removeProperty", property);
        }
        
        public nsAString GetAuthoredPropertyValue(nsAString property)
        {
            return this.CallMethod<nsAString>("getAuthoredPropertyValue", property);
        }
    }
}
