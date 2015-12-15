namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSRuleList : WebIDLBase
    {
        
        public CSSRuleList(nsISupports thisObject) : 
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
