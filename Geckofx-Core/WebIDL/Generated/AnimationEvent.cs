namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEvent : WebIDLBase
    {
        
        public AnimationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string AnimationName
        {
            get
            {
                return this.GetProperty<string>("animationName");
            }
        }
        
        public float ElapsedTime
        {
            get
            {
                return this.GetProperty<float>("elapsedTime");
            }
        }
        
        public string PseudoElement
        {
            get
            {
                return this.GetProperty<string>("pseudoElement");
            }
        }
    }
}
