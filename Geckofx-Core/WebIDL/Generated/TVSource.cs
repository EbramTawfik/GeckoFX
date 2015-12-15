namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVSource : WebIDLBase
    {
        
        public TVSource(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Tuner
        {
            get
            {
                return this.GetProperty<nsISupports>("tuner");
            }
        }
        
        public TVSourceType Type
        {
            get
            {
                return this.GetProperty<TVSourceType>("type");
            }
        }
        
        public bool IsScanning
        {
            get
            {
                return this.GetProperty<bool>("isScanning");
            }
        }
        
        public nsISupports CurrentChannel
        {
            get
            {
                return this.GetProperty<nsISupports>("currentChannel");
            }
        }
        
        public Promise < nsISupports[] > GetChannels()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getChannels");
        }
        
        public Promise SetCurrentChannel(nsAString channelNumber)
        {
            return this.CallMethod<Promise>("setCurrentChannel", channelNumber);
        }
        
        public Promise StartScanning(object options)
        {
            return this.CallMethod<Promise>("startScanning", options);
        }
        
        public Promise StopScanning()
        {
            return this.CallMethod<Promise>("stopScanning");
        }
    }
}
