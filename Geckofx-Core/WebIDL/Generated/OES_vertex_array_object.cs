namespace Gecko.WebIDL
{
    using System;
    
    
    public class OES_vertex_array_object : WebIDLBase
    {
        
        public OES_vertex_array_object(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports CreateVertexArrayOES()
        {
            return this.CallMethod<nsISupports>("createVertexArrayOES");
        }
        
        public void DeleteVertexArrayOES(nsISupports arrayObject)
        {
            this.CallVoidMethod("deleteVertexArrayOES", arrayObject);
        }
        
        public Boolean IsVertexArrayOES(nsISupports arrayObject)
        {
            return this.CallMethod<Boolean>("isVertexArrayOES", arrayObject);
        }
        
        public void BindVertexArrayOES(nsISupports arrayObject)
        {
            this.CallVoidMethod("bindVertexArrayOES", arrayObject);
        }
    }
}
