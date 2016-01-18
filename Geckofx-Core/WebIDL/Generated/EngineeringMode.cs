namespace Gecko.WebIDL
{
    using System;
    
    
    public class EngineeringMode : WebIDLBase
    {
        
        public EngineeringMode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <string> GetValue(string name)
        {
            return this.CallMethod<Promise <string>>("getValue", name);
        }
        
        public Promise SetValue(string name, string value)
        {
            return this.CallMethod<Promise>("setValue", name, value);
        }
    }
}
