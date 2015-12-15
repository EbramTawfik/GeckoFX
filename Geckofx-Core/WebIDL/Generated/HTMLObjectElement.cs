namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLObjectElement : WebIDLBase
    {
        
        public HTMLObjectElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Data
        {
            get
            {
                return this.GetProperty<nsAString>("data");
            }
            set
            {
                this.SetProperty("data", value);
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
        
        public bool TypeMustMatch
        {
            get
            {
                return this.GetProperty<bool>("typeMustMatch");
            }
            set
            {
                this.SetProperty("typeMustMatch", value);
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
        
        public nsAString UseMap
        {
            get
            {
                return this.GetProperty<nsAString>("useMap");
            }
            set
            {
                this.SetProperty("useMap", value);
            }
        }
        
        public nsISupports Form
        {
            get
            {
                return this.GetProperty<nsISupports>("form");
            }
        }
        
        public nsAString Width
        {
            get
            {
                return this.GetProperty<nsAString>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public nsAString Height
        {
            get
            {
                return this.GetProperty<nsAString>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public nsIDOMDocument ContentDocument
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("contentDocument");
            }
        }
        
        public nsIDOMWindow ContentWindow
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("contentWindow");
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
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString Archive
        {
            get
            {
                return this.GetProperty<nsAString>("archive");
            }
            set
            {
                this.SetProperty("archive", value);
            }
        }
        
        public nsAString Code
        {
            get
            {
                return this.GetProperty<nsAString>("code");
            }
            set
            {
                this.SetProperty("code", value);
            }
        }
        
        public bool Declare
        {
            get
            {
                return this.GetProperty<bool>("declare");
            }
            set
            {
                this.SetProperty("declare", value);
            }
        }
        
        public uint Hspace
        {
            get
            {
                return this.GetProperty<uint>("hspace");
            }
            set
            {
                this.SetProperty("hspace", value);
            }
        }
        
        public nsAString Standby
        {
            get
            {
                return this.GetProperty<nsAString>("standby");
            }
            set
            {
                this.SetProperty("standby", value);
            }
        }
        
        public uint Vspace
        {
            get
            {
                return this.GetProperty<uint>("vspace");
            }
            set
            {
                this.SetProperty("vspace", value);
            }
        }
        
        public nsAString CodeBase
        {
            get
            {
                return this.GetProperty<nsAString>("codeBase");
            }
            set
            {
                this.SetProperty("codeBase", value);
            }
        }
        
        public nsAString CodeType
        {
            get
            {
                return this.GetProperty<nsAString>("codeType");
            }
            set
            {
                this.SetProperty("codeType", value);
            }
        }
        
        public nsAString Border
        {
            get
            {
                return this.GetProperty<nsAString>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
    }
}
