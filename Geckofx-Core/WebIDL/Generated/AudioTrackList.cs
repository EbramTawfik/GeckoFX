namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioTrackList : WebIDLBase
    {
        
        public AudioTrackList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports GetTrackById(string id)
        {
            return this.CallMethod<nsISupports>("getTrackById", id);
        }
    }
}
