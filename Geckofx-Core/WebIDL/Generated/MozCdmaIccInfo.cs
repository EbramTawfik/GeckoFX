namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCdmaIccInfo : WebIDLBase
    {
        
        public MozCdmaIccInfo(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Mdn
        {
            get
            {
                return this.GetProperty<nsAString>("mdn");
            }
        }
        
        public int PrlVersion
        {
            get
            {
                return this.GetProperty<int>("prlVersion");
            }
        }
    }
}
