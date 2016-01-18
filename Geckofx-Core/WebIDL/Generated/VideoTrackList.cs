namespace Gecko.WebIDL
{
    using System;
    
    
    public class VideoTrackList : WebIDLBase
    {
        
        public VideoTrackList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public int SelectedIndex
        {
            get
            {
                return this.GetProperty<int>("selectedIndex");
            }
        }
        
        public nsISupports GetTrackById(nsAString id)
        {
            return this.CallMethod<nsISupports>("getTrackById", id);
        }
    }
}
