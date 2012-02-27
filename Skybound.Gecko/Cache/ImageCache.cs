using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Cache
{
	public sealed class ImageCache
	{
		private ServiceWrapper<imgICache> _imgCache;

		public ImageCache()
		{
			_imgCache = new ServiceWrapper<imgICache>(Contracts.ImageCache);
		}

		public void ClearCache(bool chrome)
		{
			_imgCache.Instance.ClearCache(chrome);
			
		}

		public object FindEntryProperties(string url)
		{
			// TODO - Add nsIProperties wrapper
			var xpComUri = IOService.CreateNsIUri(url);
			return _imgCache.Instance.FindEntryProperties(xpComUri);
		}

		public void RemoveEntry(string url)
		{
			var xpComUri = IOService.CreateNsIUri(url);
			_imgCache.Instance.RemoveEntry(xpComUri);
		}


	}
}
