namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathElement : WebIDLBase
    {
        
        public SVGPathElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports PathLength
        {
            get
            {
                return this.GetProperty<nsISupports>("pathLength");
            }
        }
        
        public float GetTotalLength()
        {
            return this.CallMethod<float>("getTotalLength");
        }
        
        public nsISupports GetPointAtLength(float distance)
        {
            return this.CallMethod<nsISupports>("getPointAtLength", distance);
        }
        
        public uint GetPathSegAtLength(float distance)
        {
            return this.CallMethod<uint>("getPathSegAtLength", distance);
        }
        
        public nsISupports CreateSVGPathSegClosePath()
        {
            return this.CallMethod<nsISupports>("createSVGPathSegClosePath");
        }
        
        public nsISupports CreateSVGPathSegMovetoAbs(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegMovetoAbs", x, y);
        }
        
        public nsISupports CreateSVGPathSegMovetoRel(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegMovetoRel", x, y);
        }
        
        public nsISupports CreateSVGPathSegLinetoAbs(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoAbs", x, y);
        }
        
        public nsISupports CreateSVGPathSegLinetoRel(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoRel", x, y);
        }
        
        public nsISupports CreateSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoCubicAbs", x, y, x1, y1, x2, y2);
        }
        
        public nsISupports CreateSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoCubicRel", x, y, x1, y1, x2, y2);
        }
        
        public nsISupports CreateSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticAbs", x, y, x1, y1);
        }
        
        public nsISupports CreateSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticRel", x, y, x1, y1);
        }
        
        public nsISupports CreateSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegArcAbs", x, y, r1, r2, angle, largeArcFlag, sweepFlag);
        }
        
        public nsISupports CreateSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegArcRel", x, y, r1, r2, angle, largeArcFlag, sweepFlag);
        }
        
        public nsISupports CreateSVGPathSegLinetoHorizontalAbs(float x)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoHorizontalAbs", x);
        }
        
        public nsISupports CreateSVGPathSegLinetoHorizontalRel(float x)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoHorizontalRel", x);
        }
        
        public nsISupports CreateSVGPathSegLinetoVerticalAbs(float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoVerticalAbs", y);
        }
        
        public nsISupports CreateSVGPathSegLinetoVerticalRel(float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegLinetoVerticalRel", y);
        }
        
        public nsISupports CreateSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoCubicSmoothAbs", x, y, x2, y2);
        }
        
        public nsISupports CreateSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoCubicSmoothRel", x, y, x2, y2);
        }
        
        public nsISupports CreateSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticSmoothAbs", x, y);
        }
        
        public nsISupports CreateSVGPathSegCurvetoQuadraticSmoothRel(float x, float y)
        {
            return this.CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticSmoothRel", x, y);
        }
    }
}
