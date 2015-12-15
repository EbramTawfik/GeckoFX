namespace Gecko.WebIDL
{
    using System;
    
    
    public class SourceBufferList : WebIDLBase
    {
        
        public SourceBufferList(nsISupports thisObject) : 
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
    }
}
