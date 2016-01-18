namespace Gecko.WebIDL
{
    using System;
    
    
    public class EngineeringMode : WebIDLBase
    {
        
        public EngineeringMode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsAString > GetValue(nsAString name)
        {
            return this.CallMethod<Promise < nsAString >>("getValue", name);
        }
        
        public Promise SetValue(nsAString name, nsAString value)
        {
            return this.CallMethod<Promise>("setValue", name, value);
        }
    }
}
