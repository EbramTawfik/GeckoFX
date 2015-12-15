namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSpeakerManager : WebIDLBase
    {
        
        public MozSpeakerManager(nsISupports thisObject) : 
                base(thisObject)
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
