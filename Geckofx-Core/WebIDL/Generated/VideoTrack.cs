namespace Gecko.WebIDL
{
    using System;
    
    
    public class VideoTrack : WebIDLBase
    {
        
        public VideoTrack(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public string Language
        {
            get
            {
                return this.GetProperty<string>("language");
            }
        }
        
        public bool Selected
        {
            get
            {
                return this.GetProperty<bool>("selected");
            }
            set
            {
                this.SetProperty("selected", value);
            }
        }
    }
}
