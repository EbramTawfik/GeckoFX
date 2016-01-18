namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSAnimation : WebIDLBase
    {
        
        public CSSAnimation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
