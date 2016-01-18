namespace Gecko.WebIDL
{
    using System;
    
    
    public class ArchiveReader : WebIDLBase
    {
        
        public ArchiveReader(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
