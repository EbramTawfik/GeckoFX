namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLParamElement : WebIDLBase
    {
        
        public HTMLParamElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
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
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public nsAString ValueType
        {
            get
            {
                return this.GetProperty<nsAString>("valueType");
            }
            set
            {
                this.SetProperty("valueType", value);
            }
        }
    }
}
