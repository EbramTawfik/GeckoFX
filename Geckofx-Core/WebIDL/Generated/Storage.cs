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
        
        public string Key(uint index)
        {
            return this.CallMethod<string>("key", index);
        }
    }
}
