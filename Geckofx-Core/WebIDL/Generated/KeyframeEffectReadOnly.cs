namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyframeEffectReadOnly : WebIDLBase
    {
        
        public KeyframeEffectReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement Target
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("target");
            }
        }
        
        public IterationCompositeOperation IterationComposite
        {
            get
            {
                return this.GetProperty<IterationCompositeOperation>("iterationComposite");
            }
        }
        
        public CompositeOperation Composite
        {
            get
            {
                return this.GetProperty<CompositeOperation>("composite");
            }
        }
        
        public string Spacing
        {
            get
            {
                return this.GetProperty<string>("spacing");
            }
        }
        
        public object[] GetFrames()
        {
            return this.CallMethod<object[]>("getFrames");
        }
    }
}
