namespace Gecko.WebIDL
{
    using System;
    
    
    public class Plugin : WebIDLBase
    {
        
        public Plugin(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Description
        {
            get
            {
                return this.GetProperty<nsAString>("description");
            }
        }
        
        public nsAString Filename
        {
            get
            {
                return this.GetProperty<nsAString>("filename");
            }
        }
        
        public nsAString Version
        {
            get
            {
                return this.GetProperty<nsAString>("version");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
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
