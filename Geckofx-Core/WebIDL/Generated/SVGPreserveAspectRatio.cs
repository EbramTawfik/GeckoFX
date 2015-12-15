namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPreserveAspectRatio : WebIDLBase
    {
        
        public SVGPreserveAspectRatio(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort Align
        {
            get
            {
                return this.GetProperty<ushort>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public ushort MeetOrSlice
        {
            get
            {
                return this.GetProperty<ushort>("meetOrSlice");
            }
            set
            {
                this.SetProperty("meetOrSlice", value);
            }
        }
    }
}
