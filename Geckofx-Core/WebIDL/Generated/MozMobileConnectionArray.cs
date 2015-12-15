namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileConnectionArray : WebIDLBase
    {
        
        public MozMobileConnectionArray(nsISupports thisObject) : 
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
    }
}
