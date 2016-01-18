namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVChannel : WebIDLBase
    {
        
        public TVChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string NetworkId
        {
            get
            {
                return this.GetProperty<string>("networkId");
            }
        }
        
        public string TransportStreamId
        {
            get
            {
                return this.GetProperty<string>("transportStreamId");
            }
        }
        
        public string ServiceId
        {
            get
            {
                return this.GetProperty<string>("serviceId");
            }
        }
        
        public nsISupports Source
        {
            get
            {
                return this.GetProperty<nsISupports>("source");
            }
        }
        
        public TVChannelType Type
        {
            get
            {
                return this.GetProperty<TVChannelType>("type");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Number
        {
            get
            {
                return this.GetProperty<string>("number");
            }
        }
        
        public bool IsEmergency
        {
            get
            {
                return this.GetProperty<bool>("isEmergency");
            }
        }
        
        public bool IsFree
        {
            get
            {
                return this.GetProperty<bool>("isFree");
            }
        }
        
        public Promise < nsISupports[] > GetPrograms()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getPrograms");
        }
        
        public Promise < nsISupports[] > GetPrograms(object options)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getPrograms", options);
        }
        
        public Promise < nsISupports > GetCurrentProgram()
        {
            return this.CallMethod<Promise < nsISupports >>("getCurrentProgram");
        }
    }
}
