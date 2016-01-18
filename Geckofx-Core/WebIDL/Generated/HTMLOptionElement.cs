namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOptionElement : WebIDLBase
    {
        
        public HTMLOptionElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
            set
            {
                this.SetProperty("label", value);
            }
        }
        
        public bool DefaultSelected
        {
            get
            {
                return this.GetProperty<bool>("defaultSelected");
            }
            set
            {
                this.SetProperty("defaultSelected", value);
            }
        }
        
        public bool Selected
        {
            get
            {
                return this.GetProperty<bool>("selected");
            }
            set
            {
                this.SetProperty("selected", value);
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
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public int Index
        {
            get
            {
                return this.GetProperty<int>("index");
            }
        }
    }
}
