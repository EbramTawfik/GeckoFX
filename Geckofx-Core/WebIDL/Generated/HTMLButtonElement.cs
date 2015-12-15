namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLButtonElement : WebIDLBase
    {
        
        public HTMLButtonElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Autofocus
        {
            get
            {
                return this.GetProperty<bool>("autofocus");
            }
            set
            {
                this.SetProperty("autofocus", value);
            }
        }
        
        public bool Disabled
        {
            get
            {
                return this.GetProperty<bool>("disabled");
            }
            set
            {
                this.SetProperty("disabled", value);
            }
        }
        
        public nsISupports Form
        {
            get
            {
                return this.GetProperty<nsISupports>("form");
            }
        }
        
        public nsAString FormAction
        {
            get
            {
                return this.GetProperty<nsAString>("formAction");
            }
            set
            {
                this.SetProperty("formAction", value);
            }
        }
        
        public nsAString FormEnctype
        {
            get
            {
                return this.GetProperty<nsAString>("formEnctype");
            }
            set
            {
                this.SetProperty("formEnctype", value);
            }
        }
        
        public nsAString FormMethod
        {
            get
            {
                return this.GetProperty<nsAString>("formMethod");
            }
            set
            {
                this.SetProperty("formMethod", value);
            }
        }
        
        public bool FormNoValidate
        {
            get
            {
                return this.GetProperty<bool>("formNoValidate");
            }
            set
            {
                this.SetProperty("formNoValidate", value);
            }
        }
        
        public nsAString FormTarget
        {
            get
            {
                return this.GetProperty<nsAString>("formTarget");
            }
            set
            {
                this.SetProperty("formTarget", value);
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
            set
            {
                this.SetProperty("type", value);
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
