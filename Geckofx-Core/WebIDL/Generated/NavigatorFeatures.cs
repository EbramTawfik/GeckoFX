namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorFeatures : WebIDLBase
    {
        
        public NavigatorFeatures(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GetFeature(string name)
        {
            return this.CallMethod<Promise <object>>("getFeature", name);
        }
        
        public Promise <object> HasFeature(string name)
        {
            return this.CallMethod<Promise <object>>("hasFeature", name);
        }
    }
}
