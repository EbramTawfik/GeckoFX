namespace Gecko.WebIDL
{
    using System;
    
    
    public class BeforeUnloadEvent : WebIDLBase
    {
        
        public BeforeUnloadEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString ReturnValue
        {
            get
            {
                return this.GetProperty<nsAString>("returnValue");
            }
            set
            {
                this.SetProperty("returnValue", value);
            }
        }
    }
}
