namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOutputElement : WebIDLBase
    {
        
        public HTMLOutputElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports HtmlFor
        {
            get
            {
                return this.GetProperty<nsISupports>("htmlFor");
            }
        }
        
        public nsISupports Form
        {
            get
            {
                return this.GetProperty<nsISupports>("form");
            }
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
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public nsAString DefaultValue
        {
            get
            {
                return this.GetProperty<nsAString>("defaultValue");
            }
            set
            {
                this.SetProperty("defaultValue", value);
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
        
        public bool WillValidate
        {
            get
            {
                return this.GetProperty<bool>("willValidate");
            }
        }
        
        public nsISupports Validity
        {
            get
            {
                return this.GetProperty<nsISupports>("validity");
            }
        }
        
        public nsAString ValidationMessage
        {
            get
            {
                return this.GetProperty<nsAString>("validationMessage");
            }
        }
        
        public bool CheckValidity()
        {
            return this.CallMethod<bool>("checkValidity");
        }
        
        public void SetCustomValidity(nsAString error)
        {
            this.CallVoidMethod("setCustomValidity", error);
        }
    }
}
