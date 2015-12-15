namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioTrackList : WebIDLBase
    {
        
        public AudioTrackList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports GetTrackById(nsAString id)
        {
            return this.CallMethod<nsISupports>("getTrackById", id);
        }
    }
}
