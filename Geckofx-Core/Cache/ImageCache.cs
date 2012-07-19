using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Cache
{
	public static class ImageCache
	{
		private static ServiceWrapper<imgICache> _imgCache;

		static ImageCache()
		{
			_imgCache = new ServiceWrapper<imgICache>(Contracts.ImageCache);
		}

		public static void ClearCache(bool chrome)
		{
			_imgCache.Instance.ClearCache(chrome);
			
		}

		public static object FindEntryProperties(string url)
		{
			// TODO - Add nsIProperties wrapper
			var xpComUri = IOService.CreateNsIUri(url);
			return _imgCache.Instance.FindEntryProperties(xpComUri);
		}

		public static void RemoveEntry(string url)
		{
			var xpComUri = IOService.CreateNsIUri(url);
			_imgCache.Instance.RemoveEntry(xpComUri);
		}


	}
}
