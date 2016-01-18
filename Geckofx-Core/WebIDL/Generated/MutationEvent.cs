namespace Gecko.WebIDL
{
    using System;
    
    
    public class MutationEvent : WebIDLBase
    {
        
        public MutationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode RelatedNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("relatedNode");
            }
        }
        
        public nsAString PrevValue
        {
            get
            {
                return this.GetProperty<nsAString>("prevValue");
            }
        }
        
        public nsAString NewValue
        {
            get
            {
                return this.GetProperty<nsAString>("newValue");
            }
        }
        
        public nsAString AttrName
        {
            get
            {
                return this.GetProperty<nsAString>("attrName");
            }
        }
        
        public ushort AttrChange
        {
            get
            {
                return this.GetProperty<ushort>("attrChange");
            }
        }
        
        public void InitMutationEvent(nsAString type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, nsAString prevValue, nsAString newValue, nsAString attrName, ushort attrChange)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue, attrName, attrChange);
        }
    }
}
