namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSAnimation : WebIDLBase
    {
        
        public CSSAnimation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
