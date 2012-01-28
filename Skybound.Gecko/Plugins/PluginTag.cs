namespace Gecko.Plugins
{
	public sealed class PluginTag
	{
		private nsIPluginTag _pluginTag;

		internal PluginTag(nsIPluginTag pluginTag)
		{
			_pluginTag = pluginTag;
		}

		public bool Blocklisted
		{
			get { return _pluginTag.GetBlocklistedAttribute(); }
			set{_pluginTag.SetBlocklistedAttribute( value );}
		}

		public string Description
		{
			get { return nsString.Get( _pluginTag.GetDescriptionAttribute ); }
		}

		public bool Disabled
		{
			get { return _pluginTag.GetDisabledAttribute(); }
			set { _pluginTag.SetDisabledAttribute(value); }
		}

		public string FileName
		{
			get { return nsString.Get(_pluginTag.GetFilenameAttribute); }
		}

		public string Fullpath
		{
			get { return nsString.Get(_pluginTag.GetFullpathAttribute); }
		}

		public string Name
		{
			get { return nsString.Get(_pluginTag.GetNameAttribute); }
		}

		public string Version
		{
			get { return nsString.Get(_pluginTag.GetVersionAttribute); }
		}
	}
}