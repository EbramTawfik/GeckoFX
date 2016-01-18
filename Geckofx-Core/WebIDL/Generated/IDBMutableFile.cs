namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBMutableFile : WebIDLBase
    {
        
        public IDBMutableFile(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsISupports Database
        {
            get
            {
                return this.GetProperty<nsISupports>("database");
            }
        }
        
        public nsISupports Open()
        {
            return this.CallMethod<nsISupports>("open");
        }
        
        public nsISupports Open(FileMode mode)
        {
            return this.CallMethod<nsISupports>("open", mode);
        }
        
        public nsISupports GetFile()
        {
            return this.CallMethod<nsISupports>("getFile");
        }
    }
}
