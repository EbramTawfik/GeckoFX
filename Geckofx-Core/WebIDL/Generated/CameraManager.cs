namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraManager : WebIDLBase
    {
        
        public CameraManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GetCamera(string camera)
        {
            return this.CallMethod<Promise <object>>("getCamera", camera);
        }
        
        public Promise <object> GetCamera(string camera, object initialConfiguration)
        {
            return this.CallMethod<Promise <object>>("getCamera", camera, initialConfiguration);
        }
        
        public string[] GetListOfCameras()
        {
            return this.CallMethod<string[]>("getListOfCameras");
        }
    }
}
