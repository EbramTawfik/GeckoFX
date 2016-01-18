namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppMessageEvent : WebIDLBase
    {
        
        public MozInterAppMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
    }
}
