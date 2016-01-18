namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputPortManager : WebIDLBase
    {
        
        public InputPortManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetInputPorts()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getInputPorts");
        }
    }
}
