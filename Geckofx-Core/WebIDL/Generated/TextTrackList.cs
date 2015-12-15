namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrackList : WebIDLBase
    {
        
        public TextTrackList(nsISupports thisObject) : 
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
        
        public nsISupports MediaElement
        {
            get
            {
                return this.GetProperty<nsISupports>("mediaElement");
            }
        }
    }
}
