namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraManager : WebIDLBase
    {
        
        public CameraManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise <object> GetCamera(nsAString camera, object initialConfiguration)
        {
            return this.CallMethod<Promise <object>>("getCamera", camera, initialConfiguration);
        }
        
        public nsAString[] GetListOfCameras()
        {
            return this.CallMethod<nsAString[]>("getListOfCameras");
        }
    }
}
