namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVChannel : WebIDLBase
    {
        
        public TVChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString NetworkId
        {
            get
            {
                return this.GetProperty<nsAString>("networkId");
            }
        }
        
        public nsAString TransportStreamId
        {
            get
            {
                return this.GetProperty<nsAString>("transportStreamId");
            }
        }
        
        public nsAString ServiceId
        {
            get
            {
                return this.GetProperty<nsAString>("serviceId");
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
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString Number
        {
            get
            {
                return this.GetProperty<nsAString>("number");
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
