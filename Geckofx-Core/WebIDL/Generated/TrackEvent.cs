namespace Gecko.WebIDL
{
    using System;
    
    
    public class TrackEvent : WebIDLBase
    {
        
        public TrackEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsISupports,nsISupports> Track
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports,nsISupports>>("track");
            }
        }
    }
}
