namespace Gecko.WebIDL
{
    using System;
    
    
    public class HashChangeEvent : WebIDLBase
    {
        
        public HashChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString OldURL
        {
            get
            {
                return this.GetProperty<nsAString>("oldURL");
            }
        }
        
        public nsAString NewURL
        {
            get
            {
                return this.GetProperty<nsAString>("newURL");
            }
        }
        
        public void InitHashChangeEvent(nsAString typeArg, bool canBubbleArg, bool cancelableArg, nsAString oldURLArg, nsAString newURLArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg, cancelableArg, oldURLArg, newURLArg);
        }
    }
}
