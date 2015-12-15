namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScriptProcessorNode : WebIDLBase
    {
        
        public ScriptProcessorNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int BufferSize
        {
            get
            {
                return this.GetProperty<int>("bufferSize");
            }
        }
    }
}
