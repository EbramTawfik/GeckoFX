namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_draw_buffers : WebIDLBase
    {
        
        public WEBGL_draw_buffers(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void DrawBuffersWEBGL(UInt32[] buffers)
        {
            this.CallVoidMethod("drawBuffersWEBGL", buffers);
        }
    }
}
