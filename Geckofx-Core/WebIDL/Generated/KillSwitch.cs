namespace Gecko.WebIDL
{
    using System;
    
    
    public class KillSwitch : WebIDLBase
    {
        
        public KillSwitch(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> Enable()
        {
            return this.CallMethod<Promise <object>>("enable");
        }
        
        public Promise <object> Disable()
        {
            return this.CallMethod<Promise <object>>("disable");
        }
    }
}
