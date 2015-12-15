namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLModElement : WebIDLBase
    {
        
        public HTMLModElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Cite
        {
            get
            {
                return this.GetProperty<nsAString>("cite");
            }
            set
            {
                this.SetProperty("cite", value);
            }
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
