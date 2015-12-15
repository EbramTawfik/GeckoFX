namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowModal : WebIDLBase
    {
        
        public WindowModal(nsISupports thisObject) : 
                base(thisObject)
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
