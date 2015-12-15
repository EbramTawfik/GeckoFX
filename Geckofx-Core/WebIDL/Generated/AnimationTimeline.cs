namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationTimeline : WebIDLBase
    {
        
        public AnimationTimeline(nsISupports thisObject) : 
                base(thisObject)
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
