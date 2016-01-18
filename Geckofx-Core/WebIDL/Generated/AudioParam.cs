namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioParam : WebIDLBase
    {
        
        public AudioParam(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float Value
        {
            get
            {
                return this.GetProperty<float>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public float DefaultValue
        {
            get
            {
                return this.GetProperty<float>("defaultValue");
            }
        }
        
        public void SetValueAtTime(float value, double startTime)
        {
            this.CallVoidMethod("setValueAtTime", value, startTime);
        }
        
        public void LinearRampToValueAtTime(float value, double endTime)
        {
            this.CallVoidMethod("linearRampToValueAtTime", value, endTime);
        }
        
        public void ExponentialRampToValueAtTime(float value, double endTime)
        {
            this.CallVoidMethod("exponentialRampToValueAtTime", value, endTime);
        }
        
        public void SetTargetAtTime(float target, double startTime, double timeConstant)
        {
            this.CallVoidMethod("setTargetAtTime", target, startTime, timeConstant);
        }
        
        public void SetValueCurveAtTime(IntPtr values, double startTime, double duration)
        {
            this.CallVoidMethod("setValueCurveAtTime", values, startTime, duration);
        }
        
        public void CancelScheduledValues(double startTime)
        {
            this.CallVoidMethod("cancelScheduledValues", startTime);
        }
        
        public uint ParentNodeId
        {
            get
            {
                return this.GetProperty<uint>("parentNodeId");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
    }
}
