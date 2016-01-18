namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowModal : WebIDLBase
    {
        
        public WindowModal(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object DialogArguments
        {
            get
            {
                return this.GetProperty<object>("dialogArguments");
            }
        }
        
        public object ReturnValue
        {
            get
            {
                return this.GetProperty<object>("returnValue");
            }
            set
            {
                this.SetProperty("returnValue", value);
            }
        }
    }
}
