namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTextContentElement : WebIDLBase
    {
        
        public SVGTextContentElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports TextLength
        {
            get
            {
                return this.GetProperty<nsISupports>("textLength");
            }
        }
        
        public nsISupports LengthAdjust
        {
            get
            {
                return this.GetProperty<nsISupports>("lengthAdjust");
            }
        }
        
        public int GetNumberOfChars()
        {
            return this.CallMethod<int>("getNumberOfChars");
        }
        
        public float GetComputedTextLength()
        {
            return this.CallMethod<float>("getComputedTextLength");
        }
        
        public float GetSubStringLength(uint charnum, uint nchars)
        {
            return this.CallMethod<float>("getSubStringLength", charnum, nchars);
        }
        
        public nsISupports GetStartPositionOfChar(uint charnum)
        {
            return this.CallMethod<nsISupports>("getStartPositionOfChar", charnum);
        }
        
        public nsISupports GetEndPositionOfChar(uint charnum)
        {
            return this.CallMethod<nsISupports>("getEndPositionOfChar", charnum);
        }
        
        public nsISupports GetExtentOfChar(uint charnum)
        {
            return this.CallMethod<nsISupports>("getExtentOfChar", charnum);
        }
        
        public float GetRotationOfChar(uint charnum)
        {
            return this.CallMethod<float>("getRotationOfChar", charnum);
        }
        
        public int GetCharNumAtPosition(nsISupports point)
        {
            return this.CallMethod<int>("getCharNumAtPosition", point);
        }
        
        public void SelectSubString(uint charnum, uint nchars)
        {
            this.CallVoidMethod("selectSubString", charnum, nchars);
        }
    }
}
