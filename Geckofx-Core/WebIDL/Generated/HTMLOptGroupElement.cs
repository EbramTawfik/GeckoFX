namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOptGroupElement : WebIDLBase
    {
        
        public HTMLOptGroupElement(nsISupports thisObject) : 
                base(thisObject)
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
    }
}
