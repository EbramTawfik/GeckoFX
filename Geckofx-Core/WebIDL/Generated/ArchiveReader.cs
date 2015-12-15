namespace Gecko.WebIDL
{
    using System;
    
    
    public class ArchiveReader : WebIDLBase
    {
        
        public ArchiveReader(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetFilenames()
        {
            return this.CallMethod<nsISupports>("getFilenames");
        }
        
        public nsISupports GetFile(nsAString filename)
        {
            return this.CallMethod<nsISupports>("getFile", filename);
        }
        
        public nsISupports GetFiles()
        {
            return this.CallMethod<nsISupports>("getFiles");
        }
    }
}
