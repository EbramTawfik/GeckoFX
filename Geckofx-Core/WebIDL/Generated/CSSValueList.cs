namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSValueList : WebIDLBase
    {
        
        public CSSValueList(nsISupports thisObject) : 
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
