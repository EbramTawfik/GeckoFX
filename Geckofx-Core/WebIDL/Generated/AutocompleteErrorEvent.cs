namespace Gecko.WebIDL
{
    using System;
    
    
    public class AutocompleteErrorEvent : WebIDLBase
    {
        
        public AutocompleteErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public AutoCompleteErrorReason Reason
        {
            get
            {
                return this.GetProperty<AutoCompleteErrorReason>("reason");
            }
        }
    }
}
