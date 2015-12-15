namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLShaderPrecisionFormat : WebIDLBase
    {
        
        public WebGLShaderPrecisionFormat(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Int32 RangeMin
        {
            get
            {
                return this.GetProperty<Int32>("rangeMin");
            }
        }
        
        public Int32 RangeMax
        {
            get
            {
                return this.GetProperty<Int32>("rangeMax");
            }
        }
        
        public Int32 Precision
        {
            get
            {
                return this.GetProperty<Int32>("precision");
            }
        }
    }
}
