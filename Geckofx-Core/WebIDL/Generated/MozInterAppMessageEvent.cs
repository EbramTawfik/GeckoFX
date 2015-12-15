namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppMessageEvent : WebIDLBase
    {
        
        public MozInterAppMessageEvent(nsISupports thisObject) : 
                base(thisObject)
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
