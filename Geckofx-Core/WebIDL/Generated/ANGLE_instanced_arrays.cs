namespace Gecko.WebIDL
{
    using System;
    
    
    public class ANGLE_instanced_arrays : WebIDLBase
    {
        
        public ANGLE_instanced_arrays(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawArraysInstancedANGLE(UInt32 mode, Int32 first, Int32 count, Int32 primcount)
        {
            this.CallVoidMethod("drawArraysInstancedANGLE", mode, first, count, primcount);
        }
        
        public void DrawElementsInstancedANGLE(UInt32 mode, Int32 count, UInt32 type, Int64 offset, Int32 primcount)
        {
            this.CallVoidMethod("drawElementsInstancedANGLE", mode, count, type, offset, primcount);
        }
        
        public void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor)
        {
            this.CallVoidMethod("vertexAttribDivisorANGLE", index, divisor);
        }
    }
}
