namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraManager : WebIDLBase
    {
        
        public CameraManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GetCamera(nsAString camera)
        {
            return this.CallMethod<Promise <object>>("getCamera", camera);
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
