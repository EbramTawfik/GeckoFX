using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Cache
{
    public static class ImageCache
    {
        private static ComPtr<imgICache> _imgCache;

        static ImageCache()
        {
            _imgCache = Xpcom.GetService2<imgICache>(Contracts.ImageCache);
        }

        public static void ClearCache(bool chrome)
        {
            _imgCache.Instance.ClearCache(chrome);
        }

        public static Properties FindEntryProperties(string url, GeckoDocument document)
        {
            var xpComUri = IOService.CreateNsIUri(url);
            var ret =
                _imgCache.Instance.FindEntryProperties(xpComUri, document._domDocument).Wrap((x) => new Properties(x));
            Xpcom.FreeComObject(ref xpComUri);
            return ret;
        }

// Remove entry method does not exist in gecko 45
#if false
		public static void RemoveEntry(string url)
		{
			var xpComUri = IOService.CreateNsIUri(url);
			_imgCache.Instance.RemoveEntry(xpComUri);
			Xpcom.FreeComObject(ref xpComUri);
		}
#endif
    }
}