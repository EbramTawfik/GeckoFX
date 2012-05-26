using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Plugins
{
	public static class PluginHost
	{
		private static ServiceWrapper<nsIPluginHost> _pluginHost;

		static PluginHost()
		{
			_pluginHost = new ServiceWrapper<nsIPluginHost>(Contracts.PluginHost);
		}

		public static void ReloadPlugins(bool reloadPages)
		{
			_pluginHost.Instance.ReloadPlugins( reloadPages );
		}

		public static PluginTag[] GetPluginTags()
		{
			uint count = 0;
			nsIPluginTag[] tags = null;
			_pluginHost.Instance.GetPluginTags( ref count, ref tags );
			return null;
		}

		public static bool SiteHasData(PluginTag tag, string domain)
		{
			return nsString.Pass<bool, nsIPluginTag>(_pluginHost.Instance.SiteHasData, tag._pluginTag, domain);
		}

		public static void ClearSiteData(PluginTag tag, string domain, ulong flags, long maxAge)
		{
			nsString.Set(x => _pluginHost.Instance.ClearSiteData(tag._pluginTag, x, flags, maxAge), domain);
		}
	}
}
