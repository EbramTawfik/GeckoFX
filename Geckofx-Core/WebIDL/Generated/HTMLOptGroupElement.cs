namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOptGroupElement : WebIDLBase
    {
        
        public HTMLOptGroupElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
