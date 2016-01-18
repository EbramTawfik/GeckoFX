namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_draw_buffers : WebIDLBase
    {
        
        public WEBGL_draw_buffers(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawBuffersWEBGL(UInt32[] buffers)
        {
            this.CallVoidMethod("drawBuffersWEBGL", buffers);
        }
    }
}
