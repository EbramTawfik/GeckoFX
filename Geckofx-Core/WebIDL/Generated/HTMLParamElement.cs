namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLParamElement : WebIDLBase
    {
        
        public HTMLParamElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public string ValueType
        {
            get
            {
                return this.GetProperty<string>("valueType");
            }
            set
            {
                this.SetProperty("valueType", value);
            }
        }
    }
}
