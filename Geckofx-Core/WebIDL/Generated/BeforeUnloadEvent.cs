namespace Gecko.WebIDL
{
    using System;
    
    
    public class BeforeUnloadEvent : WebIDLBase
    {
        
        public BeforeUnloadEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ReturnValue
        {
            get
            {
                return this.GetProperty<string>("returnValue");
            }
            set
            {
                this.SetProperty("returnValue", value);
            }
        }
    }
}
