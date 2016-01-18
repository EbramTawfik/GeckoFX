namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowClient : WebIDLBase
    {
        
        public WindowClient(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public VisibilityState VisibilityState
        {
            get
            {
                return this.GetProperty<VisibilityState>("visibilityState");
            }
        }
        
        public bool Focused
        {
            get
            {
                return this.GetProperty<bool>("focused");
            }
        }
        
        public Promise < nsISupports > Focus()
        {
            return this.CallMethod<Promise < nsISupports >>("focus");
        }
    }
}
