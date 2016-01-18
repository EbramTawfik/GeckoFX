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
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
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
        
        public nsISupports NamedItem(nsAString name)
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
