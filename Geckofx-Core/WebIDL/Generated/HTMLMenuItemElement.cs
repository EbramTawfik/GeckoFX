namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMenuItemElement : WebIDLBase
    {
        
        public HTMLMenuItemElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Icon
        {
            get
            {
                return this.GetProperty<nsAString>("icon");
            }
            set
            {
                this.SetProperty("icon", value);
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
        
        public bool Checked
        {
            get
            {
                return this.GetProperty<bool>("checked");
            }
            set
            {
                this.SetProperty("checked", value);
            }
        }
        
        public nsAString Radiogroup
        {
            get
            {
                return this.GetProperty<nsAString>("radiogroup");
            }
            set
            {
                this.SetProperty("radiogroup", value);
            }
        }
        
        public bool DefaultChecked
        {
            get
            {
                return this.GetProperty<bool>("defaultChecked");
            }
            set
            {
                this.SetProperty("defaultChecked", value);
            }
        }
    }
}
