namespace Gecko.WebIDL
{
    using System;
    
    
    public class BeforeAfterKeyboardEvent : WebIDLBase
    {
        
        public BeforeAfterKeyboardEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public System.Nullable<bool> EmbeddedCancelled
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("embeddedCancelled");
            }
        }
    }
}
