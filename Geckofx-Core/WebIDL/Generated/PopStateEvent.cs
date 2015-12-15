namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopStateEvent : WebIDLBase
    {
        
        public PopStateEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object State
        {
            get
            {
                return this.GetProperty<object>("state");
            }
        }
    }
}
