namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorFeatures : WebIDLBase
    {
        
        public NavigatorFeatures(nsISupports thisObject) : 
                base(thisObject)
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
