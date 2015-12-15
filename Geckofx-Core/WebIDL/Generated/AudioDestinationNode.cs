namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioDestinationNode : WebIDLBase
    {
        
        public AudioDestinationNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint MaxChannelCount
        {
            get
            {
                return this.GetProperty<uint>("maxChannelCount");
            }
        }
    }
}
