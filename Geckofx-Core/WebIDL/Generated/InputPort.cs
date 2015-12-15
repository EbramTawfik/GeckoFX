namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputPort : WebIDLBase
    {
        
        public InputPort(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
        
        public bool Connected
        {
            get
            {
                return this.GetProperty<bool>("connected");
            }
        }
    }
}
