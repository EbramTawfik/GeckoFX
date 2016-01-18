namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMenuItemElement : WebIDLBase
    {
        
        public HTMLMenuItemElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
            set
            {
                this.SetProperty("label", value);
            }
        }
        
        public string Icon
        {
            get
            {
                return this.GetProperty<string>("icon");
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
        
        public string Radiogroup
        {
            get
            {
                return this.GetProperty<string>("radiogroup");
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
