namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerDebuggerGlobalScope : WebIDLBase
    {
        
        public WorkerDebuggerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Global
        {
            get
            {
                return this.GetProperty<object>("global");
            }
        }
        
        public object CreateSandbox(string name, object prototype)
        {
            return this.CallMethod<object>("createSandbox", name, prototype);
        }
        
        public void LoadSubScript(string url)
        {
            this.CallVoidMethod("loadSubScript", url);
        }
        
        public void LoadSubScript(string url, object sandbox)
        {
            this.CallVoidMethod("loadSubScript", url, sandbox);
        }
        
        public void EnterEventLoop()
        {
            this.CallVoidMethod("enterEventLoop");
        }
        
        public void LeaveEventLoop()
        {
            this.CallVoidMethod("leaveEventLoop");
        }
        
        public void PostMessage(string message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void ReportError(string message)
        {
            this.CallVoidMethod("reportError", message);
        }
        
        public void Dump()
        {
            this.CallVoidMethod("dump");
        }
        
        public void Dump(string @string)
        {
            this.CallVoidMethod("dump", @string);
        }
    }
}
