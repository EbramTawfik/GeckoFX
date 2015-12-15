namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozStkCommandEvent : WebIDLBase
    {
        
        public MozStkCommandEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Command
        {
            get
            {
                return this.GetProperty<object>("command");
            }
        }
    }
}
