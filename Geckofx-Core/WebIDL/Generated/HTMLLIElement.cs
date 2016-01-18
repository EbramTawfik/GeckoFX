namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLLIElement : WebIDLBase
    {
        
        public HTMLLIElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Value
        {
            get
            {
                return this.GetProperty<int>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
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
    }
}
