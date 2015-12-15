namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileList : WebIDLBase
    {
        
        public FileList(nsISupports thisObject) : 
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
