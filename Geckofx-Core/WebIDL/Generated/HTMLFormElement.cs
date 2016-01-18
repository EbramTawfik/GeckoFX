namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFormElement : WebIDLBase
    {
        
        public HTMLFormElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string AcceptCharset
        {
            get
            {
                return this.GetProperty<string>("acceptCharset");
            }
            set
            {
                this.SetProperty("acceptCharset", value);
            }
        }
        
        public string Action
        {
            get
            {
                return this.GetProperty<string>("action");
            }
            set
            {
                this.SetProperty("action", value);
            }
        }
        
        public string Autocomplete
        {
            get
            {
                return this.GetProperty<string>("autocomplete");
            }
            set
            {
                this.SetProperty("autocomplete", value);
            }
        }
        
        public string Enctype
        {
            get
            {
                return this.GetProperty<string>("enctype");
            }
            set
            {
                this.SetProperty("enctype", value);
            }
        }
        
        public string Encoding
        {
            get
            {
                return this.GetProperty<string>("encoding");
            }
            set
            {
                this.SetProperty("encoding", value);
            }
        }
        
        public string Method
        {
            get
            {
                return this.GetProperty<string>("method");
            }
            set
            {
                this.SetProperty("method", value);
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
        
        public bool NoValidate
        {
            get
            {
                return this.GetProperty<bool>("noValidate");
            }
            set
            {
                this.SetProperty("noValidate", value);
            }
        }
        
        public string Target
        {
            get
            {
                return this.GetProperty<string>("target");
            }
            set
            {
                this.SetProperty("target", value);
            }
        }
        
        public nsISupports Elements
        {
            get
            {
                return this.GetProperty<nsISupports>("elements");
            }
        }
        
        public int Length
        {
            get
            {
                return this.GetProperty<int>("length");
            }
        }
        
        public void Submit()
        {
            this.CallVoidMethod("submit");
        }
        
        public void Reset()
        {
            this.CallVoidMethod("reset");
        }
        
        public bool CheckValidity()
        {
            return this.CallMethod<bool>("checkValidity");
        }
        
        public void RequestAutocomplete()
        {
            this.CallVoidMethod("requestAutocomplete");
        }
    }
}
