namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozObjectLoadingContent : WebIDLBase
    {
        
        public MozObjectLoadingContent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString ActualType
        {
            get
            {
                return this.GetProperty<nsAString>("actualType");
            }
        }
        
        public uint DisplayedType
        {
            get
            {
                return this.GetProperty<uint>("displayedType");
            }
        }
        
        public bool Activated
        {
            get
            {
                return this.GetProperty<bool>("activated");
            }
        }
        
        public nsISupports SrcURI
        {
            get
            {
                return this.GetProperty<nsISupports>("srcURI");
            }
        }
        
        public uint DefaultFallbackType
        {
            get
            {
                return this.GetProperty<uint>("defaultFallbackType");
            }
        }
        
        public uint PluginFallbackType
        {
            get
            {
                return this.GetProperty<uint>("pluginFallbackType");
            }
        }
        
        public bool HasRunningPlugin
        {
            get
            {
                return this.GetProperty<bool>("hasRunningPlugin");
            }
        }
        
        public uint RunID
        {
            get
            {
                return this.GetProperty<uint>("runID");
            }
        }
    }
}
