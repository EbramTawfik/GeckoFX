namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLUListElement : WebIDLBase
    {
        
        public HTMLUListElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Compact
        {
            get
            {
                return this.GetProperty<bool>("compact");
            }
            set
            {
                this.SetProperty("compact", value);
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
