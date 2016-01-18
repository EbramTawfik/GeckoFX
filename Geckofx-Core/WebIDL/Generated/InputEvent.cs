namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputEvent : WebIDLBase
    {
        
        public InputEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool IsComposing
        {
            get
            {
                return this.GetProperty<bool>("isComposing");
            }
        }
    }
}
