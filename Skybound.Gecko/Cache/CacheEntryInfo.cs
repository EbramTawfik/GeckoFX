namespace Gecko.Cache
{
	public class CacheEntryInfo
	{
		private nsICacheEntryInfo _cacheEntryInfo;
		internal CacheEntryInfo(nsICacheEntryInfo cacheEntryInfo)
		{
			_cacheEntryInfo = cacheEntryInfo;

		}

		public string ClientID
		{
			get { return _cacheEntryInfo.GetClientIDAttribute(); }
		}

		public uint DataSize
		{
			get { return _cacheEntryInfo.GetDataSizeAttribute(); }
		}

		public string DeviceID
		{
			get { return _cacheEntryInfo.GetDeviceIDAttribute(); }
		}

		public uint ExpirationTime
		{
			get { return _cacheEntryInfo.GetExpirationTimeAttribute(); }
		}

		public int FetchCount
		{
			get { return _cacheEntryInfo.GetFetchCountAttribute(); }
		}

		public string Key
		{
			get { return nsString.Get( _cacheEntryInfo.GetKeyAttribute ); }
		}

		public uint LastFetched
		{
			get { return _cacheEntryInfo.GetLastFetchedAttribute(); }
		}

		public uint LastModified
		{
			get { return _cacheEntryInfo.GetLastModifiedAttribute(); }
		}

		public bool IsStreamBased
		{
			get { return _cacheEntryInfo.IsStreamBased(); }
		}
	}
}