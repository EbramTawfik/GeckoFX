namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEvent : WebIDLBase
    {
        
        public AnimationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString AnimationName
        {
            get
            {
                return this.GetProperty<nsAString>("animationName");
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
