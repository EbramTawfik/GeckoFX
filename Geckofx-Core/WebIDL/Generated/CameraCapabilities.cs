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
        
        public string[] FileFormats
        {
            get
            {
                return this.GetProperty<string[]>("fileFormats");
            }
        }
        
        public string[] WhiteBalanceModes
        {
            get
            {
                return this.GetProperty<string[]>("whiteBalanceModes");
            }
        }
        
        public string[] SceneModes
        {
            get
            {
                return this.GetProperty<string[]>("sceneModes");
            }
        }
        
        public string[] Effects
        {
            get
            {
                return this.GetProperty<string[]>("effects");
            }
        }
        
        public string[] FlashModes
        {
            get
            {
                return this.GetProperty<string[]>("flashModes");
            }
        }
        
        public string[] FocusModes
        {
            get
            {
                return this.GetProperty<string[]>("focusModes");
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
        
        public string[] IsoModes
        {
            get
            {
                return this.GetProperty<string[]>("isoModes");
            }
        }
        
        public string[] MeteringModes
        {
            get
            {
                return this.GetProperty<string[]>("meteringModes");
            }
        }
    }
}
