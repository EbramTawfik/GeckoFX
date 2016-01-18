namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOListElement : WebIDLBase
    {
        
        public HTMLOListElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Reversed
        {
            get
            {
                return this.GetProperty<bool>("reversed");
            }
            set
            {
                this.SetProperty("reversed", value);
            }
        }
        
        public int Start
        {
            get
            {
                return this.GetProperty<int>("start");
            }
            set
            {
                this.SetProperty("start", value);
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
