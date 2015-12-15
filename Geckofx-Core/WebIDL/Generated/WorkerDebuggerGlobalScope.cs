namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerDebuggerGlobalScope : WebIDLBase
    {
        
        public WorkerDebuggerGlobalScope(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Global
        {
            get
            {
                return this.GetProperty<object>("global");
            }
        }
        
        public object CreateSandbox(nsAString name, object prototype)
        {
            return this.CallMethod<object>("createSandbox", name, prototype);
        }
        
        public void LoadSubScript(nsAString url, object sandbox)
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
        
        public void PostMessage(nsAString message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void ReportError(nsAString message)
        {
            this.CallVoidMethod("reportError", message);
        }
        
        public void Dump(nsAString @string)
        {
            this.CallVoidMethod("dump", @string);
        }
    }
}
