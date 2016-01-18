namespace Gecko.WebIDL
{
    using System;
    
    
    public class CommandEvent : WebIDLBase
    {
        
        public CommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Command
        {
            get
            {
                return this.GetProperty<nsAString>("command");
            }
        }
        
        public void InitCommandEvent(nsAString type, bool canBubble, bool cancelable, nsAString command)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, command);
        }
    }
}
