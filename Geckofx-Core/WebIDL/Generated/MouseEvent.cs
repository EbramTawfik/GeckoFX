namespace Gecko.WebIDL
{
    using System;
    
    
    public class MouseEvent : WebIDLBase
    {
        
        public MouseEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int ScreenX
        {
            get
            {
                return this.GetProperty<int>("screenX");
            }
        }
        
        public int ScreenY
        {
            get
            {
                return this.GetProperty<int>("screenY");
            }
        }
        
        public int ClientX
        {
            get
            {
                return this.GetProperty<int>("clientX");
            }
        }
        
        public int ClientY
        {
            get
            {
                return this.GetProperty<int>("clientY");
            }
        }
        
        public int OffsetX
        {
            get
            {
                return this.GetProperty<int>("offsetX");
            }
        }
        
        public int OffsetY
        {
            get
            {
                return this.GetProperty<int>("offsetY");
            }
        }
        
        public bool CtrlKey
        {
            get
            {
                return this.GetProperty<bool>("ctrlKey");
            }
        }
        
        public bool ShiftKey
        {
            get
            {
                return this.GetProperty<bool>("shiftKey");
            }
        }
        
        public bool AltKey
        {
            get
            {
                return this.GetProperty<bool>("altKey");
            }
        }
        
        public bool MetaKey
        {
            get
            {
                return this.GetProperty<bool>("metaKey");
            }
        }
        
        public short Button
        {
            get
            {
                return this.GetProperty<short>("button");
            }
        }
        
        public ushort Buttons
        {
            get
            {
                return this.GetProperty<ushort>("buttons");
            }
        }
        
        public nsISupports RelatedTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("relatedTarget");
            }
        }
        
        public nsAString Region
        {
            get
            {
                return this.GetProperty<nsAString>("region");
            }
        }
        
        public int MovementX
        {
            get
            {
                return this.GetProperty<int>("movementX");
            }
        }
        
        public int MovementY
        {
            get
            {
                return this.GetProperty<int>("movementY");
            }
        }
        
        public void InitMouseEvent(nsAString typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        }
        
        public bool GetModifierState(nsAString keyArg)
        {
            return this.CallMethod<bool>("getModifierState", keyArg);
        }
        
        public int MozMovementX
        {
            get
            {
                return this.GetProperty<int>("mozMovementX");
            }
        }
        
        public int MozMovementY
        {
            get
            {
                return this.GetProperty<int>("mozMovementY");
            }
        }
        
        public float MozPressure
        {
            get
            {
                return this.GetProperty<float>("mozPressure");
            }
        }
        
        public ushort MozInputSource
        {
            get
            {
                return this.GetProperty<ushort>("mozInputSource");
            }
        }
        
        public bool HitCluster
        {
            get
            {
                return this.GetProperty<bool>("hitCluster");
            }
        }
        
        public void InitNSMouseEvent(
                    nsAString typeArg, 
                    bool canBubbleArg, 
                    bool cancelableArg, 
                    nsIDOMWindow viewArg, 
                    int detailArg, 
                    int screenXArg, 
                    int screenYArg, 
                    int clientXArg, 
                    int clientYArg, 
                    bool ctrlKeyArg, 
                    bool altKeyArg, 
                    bool shiftKeyArg, 
                    bool metaKeyArg, 
                    short buttonArg, 
                    nsISupports relatedTargetArg, 
                    float pressure, 
                    ushort inputSourceArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, pressure, inputSourceArg);
        }
    }
}
