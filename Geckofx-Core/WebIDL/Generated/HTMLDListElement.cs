namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDListElement : WebIDLBase
    {
        
        public HTMLDListElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
    }
}
