namespace Gecko.WebIDL
{
    using System;
    
    
    public class TransitionEvent : WebIDLBase
    {
        
        public TransitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString PropertyName
        {
            get
            {
                return this.GetProperty<nsAString>("propertyName");
            }
        }
        
        public float ElapsedTime
        {
            get
            {
                return this.GetProperty<float>("elapsedTime");
            }
        }
        
        public nsAString PseudoElement
        {
            get
            {
                return this.GetProperty<nsAString>("pseudoElement");
            }
        }
    }
}
