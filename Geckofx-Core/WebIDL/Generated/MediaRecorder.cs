namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaRecorder : WebIDLBase
    {
        
        public MediaRecorder(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
        
        public RecordingState State
        {
            get
            {
                return this.GetProperty<RecordingState>("state");
            }
        }
        
        public nsAString MimeType
        {
            get
            {
                return this.GetProperty<nsAString>("mimeType");
            }
        }
        
        public void Start(int timeSlice)
        {
            this.CallVoidMethod("start", timeSlice);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Pause()
        {
            this.CallVoidMethod("pause");
        }
        
        public void Resume()
        {
            this.CallVoidMethod("resume");
        }
        
        public void RequestData()
        {
            this.CallVoidMethod("requestData");
        }
    }
}
