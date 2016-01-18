namespace Gecko.WebIDL
{
    using System;
    
    
    public class PropertyNodeList : WebIDLBase
    {
        
        public PropertyNodeList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Object[] GetValues()
        {
            return this.CallMethod<Object[]>("getValues");
        }
    }
}
