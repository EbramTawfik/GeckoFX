namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGSVGElement : WebIDLBase
    {
        
        public SVGSVGElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports X
        {
            get
            {
                return this.GetProperty<nsISupports>("x");
            }
        }
        
        public nsISupports Y
        {
            get
            {
                return this.GetProperty<nsISupports>("y");
            }
        }
        
        public nsISupports Width
        {
            get
            {
                return this.GetProperty<nsISupports>("width");
            }
        }
        
        public nsISupports Height
        {
            get
            {
                return this.GetProperty<nsISupports>("height");
            }
        }
        
        public float PixelUnitToMillimeterX
        {
            get
            {
                return this.GetProperty<float>("pixelUnitToMillimeterX");
            }
        }
        
        public float PixelUnitToMillimeterY
        {
            get
            {
                return this.GetProperty<float>("pixelUnitToMillimeterY");
            }
        }
        
        public float ScreenPixelToMillimeterX
        {
            get
            {
                return this.GetProperty<float>("screenPixelToMillimeterX");
            }
        }
        
        public float ScreenPixelToMillimeterY
        {
            get
            {
                return this.GetProperty<float>("screenPixelToMillimeterY");
            }
        }
        
        public bool UseCurrentView
        {
            get
            {
                return this.GetProperty<bool>("useCurrentView");
            }
        }
        
        public float CurrentScale
        {
            get
            {
                return this.GetProperty<float>("currentScale");
            }
            set
            {
                this.SetProperty("currentScale", value);
            }
        }
        
        public nsISupports CurrentTranslate
        {
            get
            {
                return this.GetProperty<nsISupports>("currentTranslate");
            }
        }
        
        public uint SuspendRedraw(uint maxWaitMilliseconds)
        {
            return this.CallMethod<uint>("suspendRedraw", maxWaitMilliseconds);
        }
        
        public void UnsuspendRedraw(uint suspendHandleID)
        {
            this.CallVoidMethod("unsuspendRedraw", suspendHandleID);
        }
        
        public void UnsuspendRedrawAll()
        {
            this.CallVoidMethod("unsuspendRedrawAll");
        }
        
        public void ForceRedraw()
        {
            this.CallVoidMethod("forceRedraw");
        }
        
        public void PauseAnimations()
        {
            this.CallVoidMethod("pauseAnimations");
        }
        
        public void UnpauseAnimations()
        {
            this.CallVoidMethod("unpauseAnimations");
        }
        
        public bool AnimationsPaused()
        {
            return this.CallMethod<bool>("animationsPaused");
        }
        
        public float GetCurrentTime()
        {
            return this.CallMethod<float>("getCurrentTime");
        }
        
        public void SetCurrentTime(float seconds)
        {
            this.CallVoidMethod("setCurrentTime", seconds);
        }
        
        public void DeselectAll()
        {
            this.CallVoidMethod("deselectAll");
        }
        
        public nsISupports CreateSVGNumber()
        {
            return this.CallMethod<nsISupports>("createSVGNumber");
        }
        
        public nsISupports CreateSVGLength()
        {
            return this.CallMethod<nsISupports>("createSVGLength");
        }
        
        public nsISupports CreateSVGAngle()
        {
            return this.CallMethod<nsISupports>("createSVGAngle");
        }
        
        public nsISupports CreateSVGPoint()
        {
            return this.CallMethod<nsISupports>("createSVGPoint");
        }
        
        public nsISupports CreateSVGMatrix()
        {
            return this.CallMethod<nsISupports>("createSVGMatrix");
        }
        
        public nsISupports CreateSVGRect()
        {
            return this.CallMethod<nsISupports>("createSVGRect");
        }
        
        public nsISupports CreateSVGTransform()
        {
            return this.CallMethod<nsISupports>("createSVGTransform");
        }
        
        public nsISupports CreateSVGTransformFromMatrix(nsISupports matrix)
        {
            return this.CallMethod<nsISupports>("createSVGTransformFromMatrix", matrix);
        }
        
        public nsIDOMElement GetElementById(nsAString elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
    }
}
