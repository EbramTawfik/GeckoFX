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
        
        public string PluginDumpID
        {
            get
            {
                return this.GetProperty<string>("pluginDumpID");
            }
        }
        
        public string PluginName
        {
            get
            {
                return this.GetProperty<string>("pluginName");
            }
        }
        
        public string BrowserDumpID
        {
            get
            {
                return this.GetProperty<string>("browserDumpID");
            }
        }
        
        public string PluginFilename
        {
            get
            {
                return this.GetProperty<string>("pluginFilename");
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
