namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrackCueList : WebIDLBase
    {
        
        public TextTrackCueList(nsISupports thisObject) : 
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
        
        public nsISupports GetCueById(nsAString id)
        {
            return this.CallMethod<nsISupports>("getCueById", id);
        }
    }
}
