namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSStyleSheet : WebIDLBase
    {
        
        public CSSStyleSheet(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports OwnerRule
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerRule");
            }
        }
        
        public nsISupports CssRules
        {
            get
            {
                return this.GetProperty<nsISupports>("cssRules");
            }
        }
        
        public uint InsertRule(nsAString rule, uint index)
        {
            return this.CallMethod<uint>("insertRule", rule, index);
        }
        
        public void DeleteRule(uint index)
        {
            this.CallVoidMethod("deleteRule", index);
        }
    }
}
