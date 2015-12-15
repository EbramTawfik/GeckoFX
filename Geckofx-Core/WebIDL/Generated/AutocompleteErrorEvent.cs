namespace Gecko.WebIDL
{
    using System;
    
    
    public class AutocompleteErrorEvent : WebIDLBase
    {
        
        public AutocompleteErrorEvent(nsISupports thisObject) : 
                base(thisObject)
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
