namespace Gecko.WebIDL
{
    using System;
    
    
    public class Storage : WebIDLBase
    {
        
        public Storage(nsISupports thisObject) : 
                base(thisObject)
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
