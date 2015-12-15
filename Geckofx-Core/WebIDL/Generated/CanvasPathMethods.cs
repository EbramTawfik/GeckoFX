namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasPathMethods : WebIDLBase
    {
        
        public CanvasPathMethods(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void ClosePath()
        {
            this.CallVoidMethod("closePath");
        }
        
        public void MoveTo(double x, double y)
        {
            this.CallVoidMethod("moveTo", x, y);
        }
        
        public void LineTo(double x, double y)
        {
            this.CallVoidMethod("lineTo", x, y);
        }
        
        public void QuadraticCurveTo(double cpx, double cpy, double x, double y)
        {
            this.CallVoidMethod("quadraticCurveTo", cpx, cpy, x, y);
        }
        
        public void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y)
        {
            this.CallVoidMethod("bezierCurveTo", cp1x, cp1y, cp2x, cp2y, x, y);
        }
        
        public void ArcTo(double x1, double y1, double x2, double y2, double radius)
        {
            this.CallVoidMethod("arcTo", x1, y1, x2, y2, radius);
        }
        
        public void Rect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("rect", x, y, w, h);
        }
        
        public void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise)
        {
            this.CallVoidMethod("arc", x, y, radius, startAngle, endAngle, anticlockwise);
        }
    }
}
