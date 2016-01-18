namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSTransition : WebIDLBase
    {
        
        public CSSTransition(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString TransitionProperty
        {
            get
            {
                return this.GetProperty<nsAString>("transitionProperty");
            }
        }
    }
}
