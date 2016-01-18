namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSStyleDeclaration : WebIDLBase
    {
        
        public CSSStyleDeclaration(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public string GetPropertyValue(string property)
        {
            return this.CallMethod<string>("getPropertyValue", property);
        }
        
        public nsISupports GetPropertyCSSValue(string property)
        {
            return this.CallMethod<nsISupports>("getPropertyCSSValue", property);
        }
        
        public string GetPropertyPriority(string property)
        {
            return this.CallMethod<string>("getPropertyPriority", property);
        }
        
        public void SetProperty(string property, string value)
        {
            this.CallVoidMethod("setProperty", property, value);
        }
        
        public void SetProperty(string property, string value, string priority)
        {
            this.CallVoidMethod("setProperty", property, value, priority);
        }
        
        public string RemoveProperty(string property)
        {
            return this.CallMethod<string>("removeProperty", property);
        }
        
        public string GetAuthoredPropertyValue(string property)
        {
            return this.CallMethod<string>("getAuthoredPropertyValue", property);
        }
    }
}
