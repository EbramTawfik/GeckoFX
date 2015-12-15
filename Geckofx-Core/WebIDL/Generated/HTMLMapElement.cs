namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMapElement : WebIDLBase
    {
        
        public HTMLMapElement(nsISupports thisObject) : 
                base(thisObject)
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
