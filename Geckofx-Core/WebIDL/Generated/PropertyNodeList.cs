namespace Gecko.WebIDL
{
    using System;
    
    
    public class PropertyNodeList : WebIDLBase
    {
        
        public PropertyNodeList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Object[] GetValues()
        {
            return this.CallMethod<Object[]>("getValues");
        }
    }
}
