namespace Gecko.Cache
{
	public sealed class CacheDeviceInfo
	{
		private readonly nsICacheDeviceInfo _cacheDeviceInfo;

		internal CacheDeviceInfo(nsICacheDeviceInfo cacheDeviceInfo)
		{
			_cacheDeviceInfo = cacheDeviceInfo;
		}

		public string Description
		{
			get { return _cacheDeviceInfo.GetDescriptionAttribute(); }
		}

		public uint EntryCount
		{
			get { return _cacheDeviceInfo.GetEntryCountAttribute(); }
		}

		public uint MaximumSize
		{
			get { return _cacheDeviceInfo.GetMaximumSizeAttribute(); }
		}

		public uint TotalSize
		{
			get { return _cacheDeviceInfo.GetTotalSizeAttribute(); }
		}

		public string UsageReport
		{
			get { return _cacheDeviceInfo.GetUsageReportAttribute(); }
		}
	}
}