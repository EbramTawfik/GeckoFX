namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVProgram : WebIDLBase
    {
        
        public TVProgram(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString EventId
        {
            get
            {
                return this.GetProperty<nsAString>("eventId");
            }
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
        
        public nsAString Title
        {
            get
            {
                return this.GetProperty<nsAString>("title");
            }
        }
        
        public ulong StartTime
        {
            get
            {
                return this.GetProperty<ulong>("startTime");
            }
        }
        
        public ulong Duration
        {
            get
            {
                return this.GetProperty<ulong>("duration");
            }
        }
        
        public nsAString Description
        {
            get
            {
                return this.GetProperty<nsAString>("description");
            }
        }
        
        public nsAString Rating
        {
            get
            {
                return this.GetProperty<nsAString>("rating");
            }
        }
        
        public nsAString[] GetAudioLanguages()
        {
            return this.CallMethod<nsAString[]>("getAudioLanguages");
        }
        
        public nsAString[] GetSubtitleLanguages()
        {
            return this.CallMethod<nsAString[]>("getSubtitleLanguages");
        }
    }
}
