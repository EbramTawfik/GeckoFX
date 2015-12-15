namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraFacesDetectedEvent : WebIDLBase
    {
        
        public CameraFacesDetectedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] Faces
        {
            get
            {
                return this.GetProperty<nsISupports[]>("faces");
            }
        }
    }
}
