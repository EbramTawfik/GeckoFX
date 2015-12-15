namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasDrawingStyles : WebIDLBase
    {
        
        public CanvasDrawingStyles(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public double LineWidth
        {
            get
            {
                return this.GetProperty<double>("lineWidth");
            }
            set
            {
                this.SetProperty("lineWidth", value);
            }
        }
        
        public nsAString LineCap
        {
            get
            {
                return this.GetProperty<nsAString>("lineCap");
            }
            set
            {
                this.SetProperty("lineCap", value);
            }
        }
        
        public nsAString LineJoin
        {
            get
            {
                return this.GetProperty<nsAString>("lineJoin");
            }
            set
            {
                this.SetProperty("lineJoin", value);
            }
        }
        
        public double MiterLimit
        {
            get
            {
                return this.GetProperty<double>("miterLimit");
            }
            set
            {
                this.SetProperty("miterLimit", value);
            }
        }
        
        public double LineDashOffset
        {
            get
            {
                return this.GetProperty<double>("lineDashOffset");
            }
            set
            {
                this.SetProperty("lineDashOffset", value);
            }
        }
        
        public nsAString Font
        {
            get
            {
                return this.GetProperty<nsAString>("font");
            }
            set
            {
                this.SetProperty("font", value);
            }
        }
        
        public nsAString TextAlign
        {
            get
            {
                return this.GetProperty<nsAString>("textAlign");
            }
            set
            {
                this.SetProperty("textAlign", value);
            }
        }
        
        public nsAString TextBaseline
        {
            get
            {
                return this.GetProperty<nsAString>("textBaseline");
            }
            set
            {
                this.SetProperty("textBaseline", value);
            }
        }
        
        public void SetLineDash(double[] segments)
        {
            this.CallVoidMethod("setLineDash", segments);
        }
        
        public double[] GetLineDash()
        {
            return this.CallMethod<double[]>("getLineDash");
        }
    }
}
