namespace Gecko.WebIDL
{
    using System;
    
    
    public class TelephonyCall : WebIDLBase
    {
        
        public TelephonyCall(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint ServiceId
        {
            get
            {
                return this.GetProperty<uint>("serviceId");
            }
        }
        
        public nsISupports Id
        {
            get
            {
                return this.GetProperty<nsISupports>("id");
            }
        }
        
        public nsISupports SecondId
        {
            get
            {
                return this.GetProperty<nsISupports>("secondId");
            }
        }
        
        public TelephonyCallState State
        {
            get
            {
                return this.GetProperty<TelephonyCallState>("state");
            }
        }
        
        public bool Emergency
        {
            get
            {
                return this.GetProperty<bool>("emergency");
            }
        }
        
        public bool Switchable
        {
            get
            {
                return this.GetProperty<bool>("switchable");
            }
        }
        
        public bool Mergeable
        {
            get
            {
                return this.GetProperty<bool>("mergeable");
            }
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public TelephonyCallDisconnectedReason DisconnectedReason
        {
            get
            {
                return this.GetProperty<TelephonyCallDisconnectedReason>("disconnectedReason");
            }
        }
        
        public nsISupports Group
        {
            get
            {
                return this.GetProperty<nsISupports>("group");
            }
        }
        
        public Promise Answer()
        {
            return this.CallMethod<Promise>("answer");
        }
        
        public Promise HangUp()
        {
            return this.CallMethod<Promise>("hangUp");
        }
        
        public Promise Hold()
        {
            return this.CallMethod<Promise>("hold");
        }
        
        public Promise Resume()
        {
            return this.CallMethod<Promise>("resume");
        }
    }
}
