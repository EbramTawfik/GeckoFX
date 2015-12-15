namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTimeElement : WebIDLBase
    {
        
        public HTMLTimeElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString DateTime
        {
            get
            {
                return this.GetProperty<nsAString>("dateTime");
            }
            set
            {
                this.SetProperty("dateTime", value);
            }
        }
    }
}
