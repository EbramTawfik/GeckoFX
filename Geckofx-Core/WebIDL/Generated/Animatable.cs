namespace Gecko.WebIDL
{
    using System;
    
    
    public class Animatable : WebIDLBase
    {
        
        public Animatable(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] GetAnimations()
        {
            return this.CallMethod<nsISupports[]>("getAnimations");
        }
    }
}
