namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLButtonElement : WebIDLBase
    {
        
        public HTMLButtonElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string FormAction
        {
            get
            {
                return this.GetProperty<string>("formAction");
            }
            set
            {
                this.SetProperty("formAction", value);
            }
        }
        
        public string FormEnctype
        {
            get
            {
                return this.GetProperty<string>("formEnctype");
            }
            set
            {
                this.SetProperty("formEnctype", value);
            }
        }
        
        public string FormMethod
        {
            get
            {
                return this.GetProperty<string>("formMethod");
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
        
        public string FormTarget
        {
            get
            {
                return this.GetProperty<string>("formTarget");
            }
            set
            {
                this.SetProperty("formTarget", value);
            }
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
        
        public string ValidationMessage
        {
            get
            {
                return this.GetProperty<string>("validationMessage");
            }
        }
        
        public bool CheckValidity()
        {
            return this.CallMethod<bool>("checkValidity");
        }
        
        public void SetCustomValidity(string error)
        {
            this.CallVoidMethod("setCustomValidity", error);
        }
    }
}
