namespace Gecko.WebIDL
{
    using System;
    
    
    public class BeforeUnloadEvent : WebIDLBase
    {
        
        public BeforeUnloadEvent(nsISupports thisObject) : 
                base(thisObject)
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
