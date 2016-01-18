namespace Gecko.WebIDL
{
    using System;
    
    
    public class InputPort : WebIDLBase
    {
        
        public InputPort(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
