using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Cache
{
	public sealed class ImageCache
	{
		private imgICache _imgCache;

		public ImageCache()
		{
			var imgCache = Xpcom.GetService<imgICache>("@mozilla.org/image/cache;1");
			_imgCache = Xpcom.QueryInterface<imgICache>(imgCache);
		}

		public void ClearCache(bool chrome)
		{
			_imgCache.ClearCache(chrome);
			
		}

		public object FindEntryProperties(string url)
		{
			// TODO - Add nsIProperties wrapper
			var xpComUri=nsURI.CreateInternal( url );
			return _imgCache.FindEntryProperties(xpComUri);
		}

		public void RemoveEntry(string url)
		{
			var xpComUri = nsURI.CreateInternal(url);
			_imgCache.RemoveEntry(xpComUri);
		}


	}
}
