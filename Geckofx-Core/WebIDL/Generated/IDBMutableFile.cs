namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBMutableFile : WebIDLBase
    {
        
        public IDBMutableFile(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public nsISupports Database
        {
            get
            {
                return this.GetProperty<nsISupports>("database");
            }
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
