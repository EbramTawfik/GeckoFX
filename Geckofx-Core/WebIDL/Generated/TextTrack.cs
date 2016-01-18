namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrack : WebIDLBase
    {
        
        public TextTrack(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public TextTrackKind Kind
        {
            get
            {
                return this.GetProperty<TextTrackKind>("kind");
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
        }
        
        public nsAString Language
        {
            get
            {
                return this.GetProperty<nsAString>("language");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsAString InBandMetadataTrackDispatchType
        {
            get
            {
                return this.GetProperty<nsAString>("inBandMetadataTrackDispatchType");
            }
        }
        
        public TextTrackMode Mode
        {
            get
            {
                return this.GetProperty<TextTrackMode>("mode");
            }
            set
            {
                this.SetProperty("mode", value);
            }
        }
        
        public nsISupports Cues
        {
            get
            {
                return this.GetProperty<nsISupports>("cues");
            }
        }
        
        public nsISupports ActiveCues
        {
            get
            {
                return this.GetProperty<nsISupports>("activeCues");
            }
        }
        
        public void AddCue(nsISupports cue)
        {
            this.CallVoidMethod("addCue", cue);
        }
        
        public void RemoveCue(nsISupports cue)
        {
            this.CallVoidMethod("removeCue", cue);
        }
        
        public nsISupports TextTrackList
        {
            get
            {
                return this.GetProperty<nsISupports>("textTrackList");
            }
        }
    }
}
