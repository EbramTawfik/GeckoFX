namespace Gecko.WebIDL
{
    using System;
    
    
    public class Animatable : WebIDLBase
    {
        
        public Animatable(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] GetAnimations()
        {
            return this.CallMethod<nsISupports[]>("getAnimations");
        }
    }
}
