namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStream : WebIDLBase
    {
        
        public MediaStream(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public double CurrentTime
        {
            get
            {
                return this.GetProperty<double>("currentTime");
            }
        }
        
        public nsISupports[] GetAudioTracks()
        {
            return this.CallMethod<nsISupports[]>("getAudioTracks");
        }
        
        public nsISupports[] GetVideoTracks()
        {
            return this.CallMethod<nsISupports[]>("getVideoTracks");
        }
        
        public nsISupports[] GetTracks()
        {
            return this.CallMethod<nsISupports[]>("getTracks");
        }
        
        public void AddTrack(nsISupports track)
        {
            this.CallVoidMethod("addTrack", track);
        }
        
        public void RemoveTrack(nsISupports track)
        {
            this.CallVoidMethod("removeTrack", track);
        }
    }
}
