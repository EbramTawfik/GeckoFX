using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Plugins
{
	public sealed class PluginHost
	{
		private nsIPluginHost _pluginHost;

		public PluginHost()
		{
			var pluginHost = Xpcom.CreateInstance<nsIPluginHost>(Contracts.PluginHost);
			_pluginHost = Xpcom.QueryInterface<nsIPluginHost>(pluginHost);

			
		}

		public void ReloadPlugins(bool reloadPages)
		{
			
			_pluginHost.ReloadPlugins( reloadPages );
		}

		public PluginTag[] GetPluginTags()
		{
			uint count = 10;
			nsIPluginTag[] tags = new nsIPluginTag[10];
			//var_pluginHost.GetPluginTags();
			return null;
		}

		public bool SiteHasData(PluginTag tag,string domain)
		{
			return nsString.Pass( _pluginHost.SiteHasData, tag._pluginTag, domain );
		}

		public void ClearSiteData(PluginTag tag,string domain,ulong flags,long maxAge)
		{
			nsString.Set( x => _pluginHost.ClearSiteData( tag._pluginTag, x, flags, maxAge ), domain );
		}
	}
}
