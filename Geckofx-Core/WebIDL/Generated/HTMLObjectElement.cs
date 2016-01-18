namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLObjectElement : WebIDLBase
    {
        
        public HTMLObjectElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Data
        {
            get
            {
                return this.GetProperty<string>("data");
            }
            set
            {
                this.SetProperty("data", value);
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
        
        public string UseMap
        {
            get
            {
                return this.GetProperty<string>("useMap");
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
        
        public string Width
        {
            get
            {
                return this.GetProperty<string>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public string Height
        {
            get
            {
                return this.GetProperty<string>("height");
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
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Archive
        {
            get
            {
                return this.GetProperty<string>("archive");
            }
            set
            {
                this.SetProperty("archive", value);
            }
        }
        
        public string Code
        {
            get
            {
                return this.GetProperty<string>("code");
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
        
        public string Standby
        {
            get
            {
                return this.GetProperty<string>("standby");
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
        
        public string CodeBase
        {
            get
            {
                return this.GetProperty<string>("codeBase");
            }
            set
            {
                this.SetProperty("codeBase", value);
            }
        }
        
        public string CodeType
        {
            get
            {
                return this.GetProperty<string>("codeType");
            }
            set
            {
                this.SetProperty("codeType", value);
            }
        }
        
        public string Border
        {
            get
            {
                return this.GetProperty<string>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
    }
}
