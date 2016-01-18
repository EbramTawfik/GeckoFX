namespace Gecko.WebIDL
{
    using System;
    
    
    public class TouchList : WebIDLBase
    {
        
        public TouchList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports IdentifiedTouch(int identifier)
        {
            return this.CallMethod<nsISupports>("identifiedTouch", identifier);
        }
    }
}
