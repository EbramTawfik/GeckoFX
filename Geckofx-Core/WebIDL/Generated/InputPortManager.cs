namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputPortManager : WebIDLBase
    {
        
        public InputPortManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetInputPorts()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getInputPorts");
        }
    }
}
