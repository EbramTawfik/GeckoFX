namespace Gecko.WebIDL
{
    using System;
    
    
    public class CommandEvent : WebIDLBase
    {
        
        public CommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Command
        {
            get
            {
                return this.GetProperty<string>("command");
            }
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, string command)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, command);
        }
    }
}
