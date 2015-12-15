namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBRElement : WebIDLBase
    {
        
        public HTMLBRElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Clear
        {
            get
            {
                return this.GetProperty<nsAString>("clear");
            }
            set
            {
                this.SetProperty("clear", value);
            }
        }
    }
}
