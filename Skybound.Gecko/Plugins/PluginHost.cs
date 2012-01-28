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
			uint count = 0;
			nsIPluginTag[] tags = null;
			_pluginHost.GetPluginTags( ref count, ref tags );
			//var_pluginHost.GetPluginTags();
			return null;
		}
	}
}
