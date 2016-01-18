namespace Gecko.WebIDL
{
    using System;
    
    
    public class UIEvent : WebIDLBase
    {
        
        public UIEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMWindow View
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("view");
            }
        }
        
        public int Detail
        {
            get
            {
                return this.GetProperty<int>("detail");
            }
        }
        
        public void InitUIEvent(nsAString aType, bool aCanBubble, bool aCancelable, nsIDOMWindow aView, int aDetail)
        {
            this.CallVoidMethod("initUIEvent", aType, aCanBubble, aCancelable, aView, aDetail);
        }
        
        public int LayerX
        {
            get
            {
                return this.GetProperty<int>("layerX");
            }
        }
        
        public int LayerY
        {
            get
            {
                return this.GetProperty<int>("layerY");
            }
        }
        
        public int PageX
        {
            get
            {
                return this.GetProperty<int>("pageX");
            }
        }
        
        public int PageY
        {
            get
            {
                return this.GetProperty<int>("pageY");
            }
        }
        
        public uint Which
        {
            get
            {
                return this.GetProperty<uint>("which");
            }
        }
        
        public nsIDOMNode RangeParent
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("rangeParent");
            }
        }
        
        public int RangeOffset
        {
            get
            {
                return this.GetProperty<int>("rangeOffset");
            }
        }
        
        public bool CancelBubble
        {
            get
            {
                return this.GetProperty<bool>("cancelBubble");
            }
            set
            {
                this.SetProperty("cancelBubble", value);
            }
        }
        
        public bool IsChar
        {
            get
            {
                return this.GetProperty<bool>("isChar");
            }
        }
    }
}
