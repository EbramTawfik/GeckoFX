namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasRenderingContext2D : WebIDLBase
    {
        
        public CanvasRenderingContext2D(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMHTMLCanvasElement Canvas
        {
            get
            {
                return this.GetProperty<nsIDOMHTMLCanvasElement>("canvas");
            }
        }
        
        public double GlobalAlpha
        {
            get
            {
                return this.GetProperty<double>("globalAlpha");
            }
            set
            {
                this.SetProperty("globalAlpha", value);
            }
        }
        
        public string GlobalCompositeOperation
        {
            get
            {
                return this.GetProperty<string>("globalCompositeOperation");
            }
            set
            {
                this.SetProperty("globalCompositeOperation", value);
            }
        }
        
        public WebIDLUnion<System.String,nsISupports,nsISupports> StrokeStyle
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.String,nsISupports,nsISupports>>("strokeStyle");
            }
            set
            {
                this.SetProperty("strokeStyle", value);
            }
        }
        
        public WebIDLUnion<System.String,nsISupports,nsISupports> FillStyle
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.String,nsISupports,nsISupports>>("fillStyle");
            }
            set
            {
                this.SetProperty("fillStyle", value);
            }
        }
        
        public double ShadowOffsetX
        {
            get
            {
                return this.GetProperty<double>("shadowOffsetX");
            }
            set
            {
                this.SetProperty("shadowOffsetX", value);
            }
        }
        
        public double ShadowOffsetY
        {
            get
            {
                return this.GetProperty<double>("shadowOffsetY");
            }
            set
            {
                this.SetProperty("shadowOffsetY", value);
            }
        }
        
        public double ShadowBlur
        {
            get
            {
                return this.GetProperty<double>("shadowBlur");
            }
            set
            {
                this.SetProperty("shadowBlur", value);
            }
        }
        
        public string ShadowColor
        {
            get
            {
                return this.GetProperty<string>("shadowColor");
            }
            set
            {
                this.SetProperty("shadowColor", value);
            }
        }
        
        public string Filter
        {
            get
            {
                return this.GetProperty<string>("filter");
            }
            set
            {
                this.SetProperty("filter", value);
            }
        }
        
        public object MozCurrentTransform
        {
            get
            {
                return this.GetProperty<object>("mozCurrentTransform");
            }
            set
            {
                this.SetProperty("mozCurrentTransform", value);
            }
        }
        
        public object MozCurrentTransformInverse
        {
            get
            {
                return this.GetProperty<object>("mozCurrentTransformInverse");
            }
            set
            {
                this.SetProperty("mozCurrentTransformInverse", value);
            }
        }
        
        public string MozFillRule
        {
            get
            {
                return this.GetProperty<string>("mozFillRule");
            }
            set
            {
                this.SetProperty("mozFillRule", value);
            }
        }
        
        public object MozDash
        {
            get
            {
                return this.GetProperty<object>("mozDash");
            }
            set
            {
                this.SetProperty("mozDash", value);
            }
        }
        
        public double MozDashOffset
        {
            get
            {
                return this.GetProperty<double>("mozDashOffset");
            }
            set
            {
                this.SetProperty("mozDashOffset", value);
            }
        }
        
        public string MozTextStyle
        {
            get
            {
                return this.GetProperty<string>("mozTextStyle");
            }
            set
            {
                this.SetProperty("mozTextStyle", value);
            }
        }
        
        public bool MozImageSmoothingEnabled
        {
            get
            {
                return this.GetProperty<bool>("mozImageSmoothingEnabled");
            }
            set
            {
                this.SetProperty("mozImageSmoothingEnabled", value);
            }
        }
        
        public void Save()
        {
            this.CallVoidMethod("save");
        }
        
        public void Restore()
        {
            this.CallVoidMethod("restore");
        }
        
        public void Scale(double x, double y)
        {
            this.CallVoidMethod("scale", x, y);
        }
        
        public void Rotate(double angle)
        {
            this.CallVoidMethod("rotate", angle);
        }
        
        public void Translate(double x, double y)
        {
            this.CallVoidMethod("translate", x, y);
        }
        
        public void Transform(double a, double b, double c, double d, double e, double f)
        {
            this.CallVoidMethod("transform", a, b, c, d, e, f);
        }
        
        public void SetTransform(double a, double b, double c, double d, double e, double f)
        {
            this.CallVoidMethod("setTransform", a, b, c, d, e, f);
        }
        
        public void ResetTransform()
        {
            this.CallVoidMethod("resetTransform");
        }
        
        public nsISupports CreateLinearGradient(double x0, double y0, double x1, double y1)
        {
            return this.CallMethod<nsISupports>("createLinearGradient", x0, y0, x1, y1);
        }
        
        public nsISupports CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1)
        {
            return this.CallMethod<nsISupports>("createRadialGradient", x0, y0, r0, x1, y1, r1);
        }
        
        public nsISupports CreatePattern(WebIDLUnion<nsIDOMHTMLImageElement,nsIDOMHTMLCanvasElement,nsISupports,nsISupports> image, string repetition)
        {
            return this.CallMethod<nsISupports>("createPattern", image, repetition);
        }
        
        public void ClearRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("clearRect", x, y, w, h);
        }
        
        public void FillRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("fillRect", x, y, w, h);
        }
        
        public void StrokeRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("strokeRect", x, y, w, h);
        }
        
        public void BeginPath()
        {
            this.CallVoidMethod("beginPath");
        }
        
        public void Fill()
        {
            this.CallVoidMethod("fill");
        }
        
        public void Fill(CanvasWindingRule winding)
        {
            this.CallVoidMethod("fill", winding);
        }
        
        public void Fill(nsISupports path)
        {
            this.CallVoidMethod("fill", path);
        }
        
        public void Fill(nsISupports path, CanvasWindingRule winding)
        {
            this.CallVoidMethod("fill", path, winding);
        }
        
        public void Stroke()
        {
            this.CallVoidMethod("stroke");
        }
        
        public void Stroke(nsISupports path)
        {
            this.CallVoidMethod("stroke", path);
        }
        
        public void DrawFocusIfNeeded(nsIDOMElement element)
        {
            this.CallVoidMethod("drawFocusIfNeeded", element);
        }
        
        public bool DrawCustomFocusRing(nsIDOMElement element)
        {
            return this.CallMethod<bool>("drawCustomFocusRing", element);
        }
        
        public void Clip()
        {
            this.CallVoidMethod("clip");
        }
        
        public void Clip(CanvasWindingRule winding)
        {
            this.CallVoidMethod("clip", winding);
        }
        
        public void Clip(nsISupports path)
        {
            this.CallVoidMethod("clip", path);
        }
        
        public void Clip(nsISupports path, CanvasWindingRule winding)
        {
            this.CallVoidMethod("clip", path, winding);
        }
        
        public bool IsPointInPath(double x, double y)
        {
            return this.CallMethod<bool>("isPointInPath", x, y);
        }
        
        public bool IsPointInPath(double x, double y, CanvasWindingRule winding)
        {
            return this.CallMethod<bool>("isPointInPath", x, y, winding);
        }
        
        public bool IsPointInPath(nsISupports path, double x, double y)
        {
            return this.CallMethod<bool>("isPointInPath", path, x, y);
        }
        
        public bool IsPointInPath(nsISupports path, double x, double y, CanvasWindingRule winding)
        {
            return this.CallMethod<bool>("isPointInPath", path, x, y, winding);
        }
        
        public bool IsPointInStroke(double x, double y)
        {
            return this.CallMethod<bool>("isPointInStroke", x, y);
        }
        
        public bool IsPointInStroke(nsISupports path, double x, double y)
        {
            return this.CallMethod<bool>("isPointInStroke", path, x, y);
        }
        
        public void FillText(string text, double x, double y)
        {
            this.CallVoidMethod("fillText", text, x, y);
        }
        
        public void FillText(string text, double x, double y, double maxWidth)
        {
            this.CallVoidMethod("fillText", text, x, y, maxWidth);
        }
        
        public void StrokeText(string text, double x, double y)
        {
            this.CallVoidMethod("strokeText", text, x, y);
        }
        
        public void StrokeText(string text, double x, double y, double maxWidth)
        {
            this.CallVoidMethod("strokeText", text, x, y, maxWidth);
        }
        
        public nsISupports MeasureText(string text)
        {
            return this.CallMethod<nsISupports>("measureText", text);
        }
        
        public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement,nsIDOMHTMLCanvasElement,nsISupports,nsISupports> image, double dx, double dy)
        {
            this.CallVoidMethod("drawImage", image, dx, dy);
        }
        
        public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement,nsIDOMHTMLCanvasElement,nsISupports,nsISupports> image, double dx, double dy, double dw, double dh)
        {
            this.CallVoidMethod("drawImage", image, dx, dy, dw, dh);
        }
        
        public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement,nsIDOMHTMLCanvasElement,nsISupports,nsISupports> image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh)
        {
            this.CallVoidMethod("drawImage", image, sx, sy, sw, sh, dx, dy, dw, dh);
        }
        
        public void AddHitRegion()
        {
            this.CallVoidMethod("addHitRegion");
        }
        
        public void AddHitRegion(object options)
        {
            this.CallVoidMethod("addHitRegion", options);
        }
        
        public void RemoveHitRegion(string id)
        {
            this.CallVoidMethod("removeHitRegion", id);
        }
        
        public void ClearHitRegions()
        {
            this.CallVoidMethod("clearHitRegions");
        }
        
        public nsISupports CreateImageData(double sw, double sh)
        {
            return this.CallMethod<nsISupports>("createImageData", sw, sh);
        }
        
        public nsISupports CreateImageData(nsISupports imagedata)
        {
            return this.CallMethod<nsISupports>("createImageData", imagedata);
        }
        
        public nsISupports GetImageData(double sx, double sy, double sw, double sh)
        {
            return this.CallMethod<nsISupports>("getImageData", sx, sy, sw, sh);
        }
        
        public void PutImageData(nsISupports imagedata, double dx, double dy)
        {
            this.CallVoidMethod("putImageData", imagedata, dx, dy);
        }
        
        public void PutImageData(nsISupports imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight)
        {
            this.CallVoidMethod("putImageData", imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
        }
        
        public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor)
        {
            this.CallVoidMethod("drawWindow", window, x, y, w, h, bgColor);
        }
        
        public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor, uint flags)
        {
            this.CallVoidMethod("drawWindow", window, x, y, w, h, bgColor, flags);
        }
        
        public void AsyncDrawXULElement(nsISupports elem, double x, double y, double w, double h, string bgColor)
        {
            this.CallVoidMethod("asyncDrawXULElement", elem, x, y, w, h, bgColor);
        }
        
        public void AsyncDrawXULElement(nsISupports elem, double x, double y, double w, double h, string bgColor, uint flags)
        {
            this.CallVoidMethod("asyncDrawXULElement", elem, x, y, w, h, bgColor, flags);
        }
        
        public void DrawWidgetAsOnScreen(nsIDOMWindow window)
        {
            this.CallVoidMethod("drawWidgetAsOnScreen", window);
        }
        
        public void Demote()
        {
            this.CallVoidMethod("demote");
        }
    }
}
