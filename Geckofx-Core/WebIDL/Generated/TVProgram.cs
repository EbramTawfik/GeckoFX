namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVProgram : WebIDLBase
    {
        
        public TVProgram(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string EventId
        {
            get
            {
                return this.GetProperty<string>("eventId");
            }
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
        
        public string Title
        {
            get
            {
                return this.GetProperty<string>("title");
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
        
        public string Description
        {
            get
            {
                return this.GetProperty<string>("description");
            }
        }
        
        public string Rating
        {
            get
            {
                return this.GetProperty<string>("rating");
            }
        }
        
        public string[] GetAudioLanguages()
        {
            return this.CallMethod<string[]>("getAudioLanguages");
        }
        
        public string[] GetSubtitleLanguages()
        {
            return this.CallMethod<string[]>("getSubtitleLanguages");
        }
    }
}
