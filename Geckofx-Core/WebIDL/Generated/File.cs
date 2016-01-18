namespace Gecko.WebIDL
{
    using System;
    
    
    public class File : WebIDLBase
    {
        
        public File(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public long LastModified
        {
            get
            {
                return this.GetProperty<long>("lastModified");
            }
        }
        
        public IntPtr LastModifiedDate
        {
            get
            {
                return this.GetProperty<IntPtr>("lastModifiedDate");
            }
        }
        
        public string Path
        {
            get
            {
                return this.GetProperty<string>("path");
            }
        }
        
        public string MozFullPath
        {
            get
            {
                return this.GetProperty<string>("mozFullPath");
            }
        }
    }
}
