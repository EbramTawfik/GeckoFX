namespace Gecko.WebIDL
{
    using System;
    
    
    public class OfflineAudioCompletionEvent : WebIDLBase
    {
        
        public OfflineAudioCompletionEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports RenderedBuffer
        {
            get
            {
                return this.GetProperty<nsISupports>("renderedBuffer");
            }
        }
    }
}
