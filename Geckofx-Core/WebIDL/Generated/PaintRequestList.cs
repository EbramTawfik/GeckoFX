namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaintRequestList : WebIDLBase
    {
        
        public PaintRequestList(nsISupports thisObject) : 
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
