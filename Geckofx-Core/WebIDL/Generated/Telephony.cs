namespace Gecko.WebIDL
{
    using System;
    
    
    public class Telephony : WebIDLBase
    {
        
        public Telephony(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Muted
        {
            get
            {
                return this.GetProperty<bool>("muted");
            }
            set
            {
                this.SetProperty("muted", value);
            }
        }
        
        public bool SpeakerEnabled
        {
            get
            {
                return this.GetProperty<bool>("speakerEnabled");
            }
            set
            {
                this.SetProperty("speakerEnabled", value);
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Active
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("active");
            }
        }
        
        public nsISupports Calls
        {
            get
            {
                return this.GetProperty<nsISupports>("calls");
            }
        }
        
        public nsISupports ConferenceGroup
        {
            get
            {
                return this.GetProperty<nsISupports>("conferenceGroup");
            }
        }
        
        public Promise Ready
        {
            get
            {
                return this.GetProperty<Promise>("ready");
            }
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> Dial(nsAString number, uint serviceId)
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("dial", number, serviceId);
        }
        
        public Promise < nsISupports > DialEmergency(nsAString number, uint serviceId)
        {
            return this.CallMethod<Promise < nsISupports >>("dialEmergency", number, serviceId);
        }
        
        public Promise SendTones(nsAString tones, uint pauseDuration, uint toneDuration, uint serviceId)
        {
            return this.CallMethod<Promise>("sendTones", tones, pauseDuration, toneDuration, serviceId);
        }
        
        public void StartTone(nsAString tone, uint serviceId)
        {
            this.CallVoidMethod("startTone", tone, serviceId);
        }
        
        public void StopTone(uint serviceId)
        {
            this.CallVoidMethod("stopTone", serviceId);
        }
        
        public void OwnAudioChannel()
        {
            this.CallVoidMethod("ownAudioChannel");
        }
    }
}
