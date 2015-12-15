namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSTransition : WebIDLBase
    {
        
        public CSSTransition(nsISupports thisObject) : 
                base(thisObject)
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
