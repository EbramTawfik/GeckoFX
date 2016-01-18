namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationTimeline : WebIDLBase
    {
        
        public AnimationTimeline(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public System.Nullable<double> CurrentTime
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("currentTime");
            }
        }
        
        public nsISupports[] GetAnimations()
        {
            return this.CallMethod<nsISupports[]>("getAnimations");
        }
    }
}
