namespace Gecko.WebIDL
{
    using System;
    
    
    public class PluginCrashedEvent : WebIDLBase
    {
        
        public PluginCrashedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint PluginID
        {
            get
            {
                return this.GetProperty<uint>("pluginID");
            }
        }
        
        public nsAString PluginDumpID
        {
            get
            {
                return this.GetProperty<nsAString>("pluginDumpID");
            }
        }
        
        public nsAString PluginName
        {
            get
            {
                return this.GetProperty<nsAString>("pluginName");
            }
        }
        
        public nsAString BrowserDumpID
        {
            get
            {
                return this.GetProperty<nsAString>("browserDumpID");
            }
        }
        
        public nsAString PluginFilename
        {
            get
            {
                return this.GetProperty<nsAString>("pluginFilename");
            }
        }
        
        public bool SubmittedCrashReport
        {
            get
            {
                return this.GetProperty<bool>("submittedCrashReport");
            }
        }
        
        public bool GmpPlugin
        {
            get
            {
                return this.GetProperty<bool>("gmpPlugin");
            }
        }
    }
}
