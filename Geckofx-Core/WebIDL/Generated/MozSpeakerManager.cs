namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSpeakerManager : WebIDLBase
    {
        
        public MozSpeakerManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Speakerforced
        {
            get
            {
                return this.GetProperty<bool>("speakerforced");
            }
        }
        
        public bool Forcespeaker
        {
            get
            {
                return this.GetProperty<bool>("forcespeaker");
            }
            set
            {
                this.SetProperty("forcespeaker", value);
            }
        }
    }
}
