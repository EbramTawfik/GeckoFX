namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationPlaybackEvent : WebIDLBase
    {
        
        public AnimationPlaybackEvent(nsISupports thisObject) : 
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
        
        public System.Nullable<double> TimelineTime
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("timelineTime");
            }
        }
    }
}
