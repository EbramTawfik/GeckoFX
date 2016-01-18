namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLModElement : WebIDLBase
    {
        
        public HTMLModElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Cite
        {
            get
            {
                return this.GetProperty<string>("cite");
            }
            set
            {
                this.SetProperty("cite", value);
            }
        }
        
        public string DateTime
        {
            get
            {
                return this.GetProperty<string>("dateTime");
            }
            set
            {
                this.SetProperty("dateTime", value);
            }
        }
    }
}
