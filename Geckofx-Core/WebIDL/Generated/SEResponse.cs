namespace Gecko.WebIDL
{
    using System;
    
    
    public class SEResponse : WebIDLBase
    {
        
        public SEResponse(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
        
        public byte Sw1
        {
            get
            {
                return this.GetProperty<byte>("sw1");
            }
        }
        
        public byte Sw2
        {
            get
            {
                return this.GetProperty<byte>("sw2");
            }
        }
        
        public byte[] Data
        {
            get
            {
                return this.GetProperty<byte[]>("data");
            }
        }
    }
}
