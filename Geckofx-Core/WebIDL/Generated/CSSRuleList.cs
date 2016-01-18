namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSRuleList : WebIDLBase
    {
        
        public CSSRuleList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
