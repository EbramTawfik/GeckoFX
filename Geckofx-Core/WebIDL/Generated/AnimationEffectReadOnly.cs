namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEffectReadOnly : WebIDLBase
    {
        
        public AnimationEffectReadOnly(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object GetComputedTiming()
        {
            return this.CallMethod<object>("getComputedTiming");
        }
    }
}
