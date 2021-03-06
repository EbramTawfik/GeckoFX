namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLSelectElement : WebIDLBase
    {
        
        public HTMLSelectElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool Multiple
        {
            get
            {
                return this.GetProperty<bool>("multiple");
            }
            set
            {
                this.SetProperty("multiple", value);
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
        
        public bool Required
        {
            get
            {
                return this.GetProperty<bool>("required");
            }
            set
            {
                this.SetProperty("required", value);
            }
        }
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsISupports Options
        {
            get
            {
                return this.GetProperty<nsISupports>("options");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
            set
            {
                this.SetProperty("length", value);
            }
        }
        
        public nsISupports SelectedOptions
        {
            get
            {
                return this.GetProperty<nsISupports>("selectedOptions");
            }
        }
        
        public int SelectedIndex
        {
            get
            {
                return this.GetProperty<int>("selectedIndex");
            }
            set
            {
                this.SetProperty("selectedIndex", value);
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
        
        public nsISupports NamedItem(string name)
        {
            return this.CallMethod<nsISupports>("namedItem", name);
        }
        
        public void Add(WebIDLUnion<nsISupports,nsISupports> element)
        {
            this.CallVoidMethod("add", element);
        }
        
        public void Add(WebIDLUnion<nsISupports,nsISupports> element, WebIDLUnion<nsISupports,System.Int32> before)
        {
            this.CallVoidMethod("add", element, before);
        }
        
        public void Remove(int index)
        {
            this.CallVoidMethod("remove", index);
        }
    }
}
