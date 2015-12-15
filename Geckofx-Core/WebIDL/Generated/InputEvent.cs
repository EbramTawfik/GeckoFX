namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputEvent : WebIDLBase
    {
        
        public InputEvent(nsISupports thisObject) : 
                base(thisObject)
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
