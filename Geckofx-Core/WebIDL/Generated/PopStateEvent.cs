namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopStateEvent : WebIDLBase
    {
        
        public PopStateEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
