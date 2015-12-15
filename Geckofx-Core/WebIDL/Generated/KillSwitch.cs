namespace Gecko.WebIDL
{
    using System;
    
    
    public class KillSwitch : WebIDLBase
    {
        
        public KillSwitch(nsISupports thisObject) : 
                base(thisObject)
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
