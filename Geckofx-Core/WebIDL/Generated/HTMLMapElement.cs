namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMapElement : WebIDLBase
    {
        
        public HTMLMapElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsISupports Areas
        {
            get
            {
                return this.GetProperty<nsISupports>("areas");
            }
        }
    }
}
