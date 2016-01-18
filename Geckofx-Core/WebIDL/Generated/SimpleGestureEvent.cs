namespace Gecko.WebIDL
{
    using System;
    
    
    public class SimpleGestureEvent : WebIDLBase
    {
        
        public SimpleGestureEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint AllowedDirections
        {
            get
            {
                return this.GetProperty<uint>("allowedDirections");
            }
            set
            {
                this.SetProperty("allowedDirections", value);
            }
        }
        
        public uint Direction
        {
            get
            {
                return this.GetProperty<uint>("direction");
            }
        }
        
        public double Delta
        {
            get
            {
                return this.GetProperty<double>("delta");
            }
        }
        
        public uint ClickCount
        {
            get
            {
                return this.GetProperty<uint>("clickCount");
            }
        }
        
        public void InitSimpleGestureEvent(
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
                    ushort buttonArg, 
                    nsISupports relatedTargetArg, 
                    uint allowedDirectionsArg, 
                    uint directionArg, 
                    double deltaArg, 
                    uint clickCount)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg, directionArg, deltaArg, clickCount);
        }
    }
}
