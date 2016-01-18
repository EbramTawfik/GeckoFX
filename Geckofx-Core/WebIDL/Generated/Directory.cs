namespace Gecko.WebIDL
{
    using System;
    
    
    public class Directory : WebIDLBase
    {
        
        public Directory(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public Promise < nsISupports > CreateFile(string path)
        {
            return this.CallMethod<Promise < nsISupports >>("createFile", path);
        }
        
        public Promise < nsISupports > CreateFile(string path, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("createFile", path, options);
        }
        
        public Promise < nsISupports > CreateDirectory(string path)
        {
            return this.CallMethod<Promise < nsISupports >>("createDirectory", path);
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> Get(string path)
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("get", path);
        }
        
        public Promise <bool> Remove(WebIDLUnion<System.String,nsISupports,nsISupports> path)
        {
            return this.CallMethod<Promise <bool>>("remove", path);
        }
        
        public Promise <bool> RemoveDeep(WebIDLUnion<System.String,nsISupports,nsISupports> path)
        {
            return this.CallMethod<Promise <bool>>("removeDeep", path);
        }
        
        public string Path
        {
            get
            {
                return this.GetProperty<string>("path");
            }
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> GetFilesAndDirectories()
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("getFilesAndDirectories");
        }
    }
}
