namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraCapabilities : WebIDLBase
    {
        
        public CameraCapabilities(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object[] PreviewSizes
        {
            get
            {
                return this.GetProperty<object[]>("previewSizes");
            }
        }
        
        public object[] PictureSizes
        {
            get
            {
                return this.GetProperty<object[]>("pictureSizes");
            }
        }
        
        public object[] ThumbnailSizes
        {
            get
            {
                return this.GetProperty<object[]>("thumbnailSizes");
            }
        }
        
        public object[] VideoSizes
        {
            get
            {
                return this.GetProperty<object[]>("videoSizes");
            }
        }
        
        public nsAString[] FileFormats
        {
            get
            {
                return this.GetProperty<nsAString[]>("fileFormats");
            }
        }
        
        public nsAString[] WhiteBalanceModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("whiteBalanceModes");
            }
        }
        
        public nsAString[] SceneModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("sceneModes");
            }
        }
        
        public nsAString[] Effects
        {
            get
            {
                return this.GetProperty<nsAString[]>("effects");
            }
        }
        
        public nsAString[] FlashModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("flashModes");
            }
        }
        
        public nsAString[] FocusModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("focusModes");
            }
        }
        
        public double[] ZoomRatios
        {
            get
            {
                return this.GetProperty<double[]>("zoomRatios");
            }
        }
        
        public uint MaxFocusAreas
        {
            get
            {
                return this.GetProperty<uint>("maxFocusAreas");
            }
        }
        
        public uint MaxMeteringAreas
        {
            get
            {
                return this.GetProperty<uint>("maxMeteringAreas");
            }
        }
        
        public uint MaxDetectedFaces
        {
            get
            {
                return this.GetProperty<uint>("maxDetectedFaces");
            }
        }
        
        public double MinExposureCompensation
        {
            get
            {
                return this.GetProperty<double>("minExposureCompensation");
            }
        }
        
        public double MaxExposureCompensation
        {
            get
            {
                return this.GetProperty<double>("maxExposureCompensation");
            }
        }
        
        public double ExposureCompensationStep
        {
            get
            {
                return this.GetProperty<double>("exposureCompensationStep");
            }
        }
        
        public nsISupports RecorderProfiles
        {
            get
            {
                return this.GetProperty<nsISupports>("recorderProfiles");
            }
        }
        
        public nsAString[] IsoModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("isoModes");
            }
        }
        
        public nsAString[] MeteringModes
        {
            get
            {
                return this.GetProperty<nsAString[]>("meteringModes");
            }
        }
    }
}
