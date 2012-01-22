using System;

namespace Gecko.Cache
{
	public sealed class CacheService
	{
		private nsICacheService _cacheService;

		public CacheService()
		{
			var cacheService = Xpcom.GetService<nsICacheService>("@mozilla.org/network/cache-service;1");
			_cacheService = Xpcom.QueryInterface<nsICacheService>(cacheService);
		}

		public CacheSession CreateSession(string clientID, nsCacheStoragePolicy storagePolicy, bool streamBased)
		{
			return new CacheSession(_cacheService.CreateSession(clientID, (IntPtr)(int)storagePolicy, streamBased));
		}


		public enum nsCacheStoragePolicy
		{
			STORE_ANYWHERE = 0,
			STORE_IN_MEMORY = 1,
			STORE_ON_DISK = 2,
			STORE_ON_DISK_AS_FILE = 3,
			STORE_OFFLINE = 4
		}
	}
}