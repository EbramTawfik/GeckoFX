namespace Gecko.WebIDL
{
    using System;
    
    
    public class VTTCue : WebIDLBase
    {
        
        public VTTCue(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Region
        {
            get
            {
                return this.GetProperty<nsISupports>("region");
            }
            set
            {
                this.SetProperty("region", value);
            }
        }
        
        public DirectionSetting Vertical
        {
            get
            {
                return this.GetProperty<DirectionSetting>("vertical");
            }
            set
            {
                this.SetProperty("vertical", value);
            }
        }
        
        public bool SnapToLines
        {
            get
            {
                return this.GetProperty<bool>("snapToLines");
            }
            set
            {
                this.SetProperty("snapToLines", value);
            }
        }
        
        public WebIDLUnion<System.Int32,AutoKeyword> Line
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.Int32,AutoKeyword>>("line");
            }
            set
            {
                this.SetProperty("line", value);
            }
        }
        
        public AlignSetting LineAlign
        {
            get
            {
                return this.GetProperty<AlignSetting>("lineAlign");
            }
            set
            {
                this.SetProperty("lineAlign", value);
            }
        }
        
        public int Position
        {
            get
            {
                return this.GetProperty<int>("position");
            }
            set
            {
                this.SetProperty("position", value);
            }
        }
        
        public AlignSetting PositionAlign
        {
            get
            {
                return this.GetProperty<AlignSetting>("positionAlign");
            }
            set
            {
                this.SetProperty("positionAlign", value);
            }
        }
        
        public int Size
        {
            get
            {
                return this.GetProperty<int>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public AlignSetting Align
        {
            get
            {
                return this.GetProperty<AlignSetting>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public nsISupports GetCueAsHTML()
        {
            return this.CallMethod<nsISupports>("getCueAsHTML");
        }
        
        public nsISupports DisplayState
        {
            get
            {
                return this.GetProperty<nsISupports>("displayState");
            }
            set
            {
                this.SetProperty("displayState", value);
            }
        }
        
        public bool HasBeenReset
        {
            get
            {
                return this.GetProperty<bool>("hasBeenReset");
            }
        }
    }
}
