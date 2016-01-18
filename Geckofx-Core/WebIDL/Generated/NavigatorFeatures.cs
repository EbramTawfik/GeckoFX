namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorFeatures : WebIDLBase
    {
        
        public NavigatorFeatures(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GetFeature(nsAString name)
        {
            return this.CallMethod<Promise <object>>("getFeature", name);
        }
        
        public Promise <object> HasFeature(nsAString name)
        {
            return this.CallMethod<Promise <object>>("hasFeature", name);
        }
    }
}
