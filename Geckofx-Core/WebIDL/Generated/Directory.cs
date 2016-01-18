namespace Gecko.WebIDL
{
    using System;
    
    
    public class Directory : WebIDLBase
    {
        
        public Directory(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public Promise < nsISupports > CreateFile(nsAString path)
        {
            return this.CallMethod<Promise < nsISupports >>("createFile", path);
        }
        
        public Promise < nsISupports > CreateFile(nsAString path, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("createFile", path, options);
        }
        
        public Promise < nsISupports > CreateDirectory(nsAString path)
        {
            return this.CallMethod<Promise < nsISupports >>("createDirectory", path);
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> Get(nsAString path)
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("get", path);
        }
        
        public Promise <bool> Remove(WebIDLUnion<nsAString,nsISupports,nsISupports> path)
        {
            return this.CallMethod<Promise <bool>>("remove", path);
        }
        
        public Promise <bool> RemoveDeep(WebIDLUnion<nsAString,nsISupports,nsISupports> path)
        {
            return this.CallMethod<Promise <bool>>("removeDeep", path);
        }
        
        public nsAString Path
        {
            get
            {
                return this.GetProperty<nsAString>("path");
            }
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> GetFilesAndDirectories()
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("getFilesAndDirectories");
        }
    }
}
