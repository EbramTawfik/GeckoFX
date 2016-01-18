namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLActiveInfo : WebIDLBase
    {
        
        public WebGLActiveInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Int32 Size
        {
            get
            {
                return this.GetProperty<Int32>("size");
            }
        }
        
        public UInt32 Type
        {
            get
            {
                return this.GetProperty<UInt32>("type");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
    }
}
