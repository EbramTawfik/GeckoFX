namespace Gecko.WebIDL
{
    using System;
    
    
    public class File : WebIDLBase
    {
        
        public File(nsISupports thisObject) : 
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
        
        public nsAString Path
        {
            get
            {
                return this.GetProperty<nsAString>("path");
            }
        }
        
        public nsAString MozFullPath
        {
            get
            {
                return this.GetProperty<nsAString>("mozFullPath");
            }
        }
    }
}
