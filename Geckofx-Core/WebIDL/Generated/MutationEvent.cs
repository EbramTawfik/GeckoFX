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
        
        public string PrevValue
        {
            get
            {
                return this.GetProperty<string>("prevValue");
            }
        }
        
        public string NewValue
        {
            get
            {
                return this.GetProperty<string>("newValue");
            }
        }
        
        public string AttrName
        {
            get
            {
                return this.GetProperty<string>("attrName");
            }
        }
        
        public ushort AttrChange
        {
            get
            {
                return this.GetProperty<ushort>("attrChange");
            }
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue, string newValue, string attrName, ushort attrChange)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue, attrName, attrChange);
        }
    }
}
