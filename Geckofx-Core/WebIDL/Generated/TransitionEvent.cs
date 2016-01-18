namespace Gecko.WebIDL
{
    using System;
    
    
    public class TransitionEvent : WebIDLBase
    {
        
        public TransitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string PropertyName
        {
            get
            {
                return this.GetProperty<string>("propertyName");
            }
        }
        
        public float ElapsedTime
        {
            get
            {
                return this.GetProperty<float>("elapsedTime");
            }
        }
        
        public string PseudoElement
        {
            get
            {
                return this.GetProperty<string>("pseudoElement");
            }
        }
    }
}
