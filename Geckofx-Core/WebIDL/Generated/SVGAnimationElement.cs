namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimationElement : WebIDLBase
    {
        
        public SVGAnimationElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports TargetElement
        {
            get
            {
                return this.GetProperty<nsISupports>("targetElement");
            }
        }
        
        public float GetStartTime()
        {
            return this.CallMethod<float>("getStartTime");
        }
        
        public float GetCurrentTime()
        {
            return this.CallMethod<float>("getCurrentTime");
        }
        
        public float GetSimpleDuration()
        {
            return this.CallMethod<float>("getSimpleDuration");
        }
        
        public void BeginElement()
        {
            this.CallVoidMethod("beginElement");
        }
        
        public void BeginElementAt(float offset)
        {
            this.CallVoidMethod("beginElementAt", offset);
        }
        
        public void EndElement()
        {
            this.CallVoidMethod("endElement");
        }
        
        public void EndElementAt(float offset)
        {
            this.CallVoidMethod("endElementAt", offset);
        }
    }
}
