namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrackCue : WebIDLBase
    {
        
        public TextTrackCue(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public double StartTime
        {
            get
            {
                return this.GetProperty<double>("startTime");
            }
            set
            {
                this.SetProperty("startTime", value);
            }
        }
        
        public double EndTime
        {
            get
            {
                return this.GetProperty<double>("endTime");
            }
            set
            {
                this.SetProperty("endTime", value);
            }
        }
        
        public bool PauseOnExit
        {
            get
            {
                return this.GetProperty<bool>("pauseOnExit");
            }
            set
            {
                this.SetProperty("pauseOnExit", value);
            }
        }
    }
}
