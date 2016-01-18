namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasDrawingStyles : WebIDLBase
    {
        
        public CanvasDrawingStyles(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string LineCap
        {
            get
            {
                return this.GetProperty<string>("lineCap");
            }
            set
            {
                this.SetProperty("lineCap", value);
            }
        }
        
        public string LineJoin
        {
            get
            {
                return this.GetProperty<string>("lineJoin");
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
        
        public string Font
        {
            get
            {
                return this.GetProperty<string>("font");
            }
            set
            {
                this.SetProperty("font", value);
            }
        }
        
        public string TextAlign
        {
            get
            {
                return this.GetProperty<string>("textAlign");
            }
            set
            {
                this.SetProperty("textAlign", value);
            }
        }
        
        public string TextBaseline
        {
            get
            {
                return this.GetProperty<string>("textBaseline");
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
