namespace Gecko.WebIDL
{
    using System;
    
    
    public class Animation : WebIDLBase
    {
        
        public Animation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Effect
        {
            get
            {
                return this.GetProperty<nsISupports>("effect");
            }
        }
        
        public nsISupports Timeline
        {
            get
            {
                return this.GetProperty<nsISupports>("timeline");
            }
        }
        
        public System.Nullable<double> StartTime
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("startTime");
            }
            set
            {
                this.SetProperty("startTime", value);
            }
        }
        
        public System.Nullable<double> CurrentTime
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("currentTime");
            }
            set
            {
                this.SetProperty("currentTime", value);
            }
        }
        
        public double PlaybackRate
        {
            get
            {
                return this.GetProperty<double>("playbackRate");
            }
            set
            {
                this.SetProperty("playbackRate", value);
            }
        }
        
        public AnimationPlayState PlayState
        {
            get
            {
                return this.GetProperty<AnimationPlayState>("playState");
            }
        }
        
        public Promise < nsISupports > Ready
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("ready");
            }
        }
        
        public Promise < nsISupports > Finished
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("finished");
            }
        }
        
        public void Cancel()
        {
            this.CallVoidMethod("cancel");
        }
        
        public void Finish()
        {
            this.CallVoidMethod("finish");
        }
        
        public void Play()
        {
            this.CallVoidMethod("play");
        }
        
        public void Pause()
        {
            this.CallVoidMethod("pause");
        }
        
        public void Reverse()
        {
            this.CallVoidMethod("reverse");
        }
        
        public bool IsRunningOnCompositor
        {
            get
            {
                return this.GetProperty<bool>("isRunningOnCompositor");
            }
        }
    }
}
