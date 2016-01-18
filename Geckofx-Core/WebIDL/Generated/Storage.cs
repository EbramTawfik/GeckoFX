namespace Gecko.WebIDL
{
    using System;
    
    
    public class Storage : WebIDLBase
    {
        
        public Storage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsAString Key(uint index)
        {
            return this.CallMethod<nsAString>("key", index);
        }
    }
}
