namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFormElement : WebIDLBase
    {
        
        public HTMLFormElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString AcceptCharset
        {
            get
            {
                return this.GetProperty<nsAString>("acceptCharset");
            }
            set
            {
                this.SetProperty("acceptCharset", value);
            }
        }
        
        public nsAString Action
        {
            get
            {
                return this.GetProperty<nsAString>("action");
            }
            set
            {
                this.SetProperty("action", value);
            }
        }
        
        public nsAString Autocomplete
        {
            get
            {
                return this.GetProperty<nsAString>("autocomplete");
            }
            set
            {
                this.SetProperty("autocomplete", value);
            }
        }
        
        public nsAString Enctype
        {
            get
            {
                return this.GetProperty<nsAString>("enctype");
            }
            set
            {
                this.SetProperty("enctype", value);
            }
        }
        
        public nsAString Encoding
        {
            get
            {
                return this.GetProperty<nsAString>("encoding");
            }
            set
            {
                this.SetProperty("encoding", value);
            }
        }
        
        public nsAString Method
        {
            get
            {
                return this.GetProperty<nsAString>("method");
            }
            set
            {
                this.SetProperty("method", value);
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
        
        public nsAString Target
        {
            get
            {
                return this.GetProperty<nsAString>("target");
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
