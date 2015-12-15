namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSAnimation : WebIDLBase
    {
        
        public CSSAnimation(nsISupports thisObject) : 
                base(thisObject)
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
