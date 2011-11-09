using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Skybound.Gecko
{
	public class ImageCreator
	{
		GeckoWebBrowser m_browser;

		public ImageCreator(GeckoWebBrowser browser)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			m_browser = browser;
		}

		public Bitmap GetBitmap(int width, int height)
		{
			return GetBitmap(0, 0, width, height);
		}

		public Bitmap GetBitmap(int xOffset, int yOffset, int width, int height)
		{
			const int SRCCOPY = 0xcc0020;

			Bitmap returnBitmap = new Bitmap(width, height);

			using (Graphics browserGraphics = Graphics.FromHwnd(m_browser.Handle), bitmapGraphics = Graphics.FromImage(returnBitmap))
			{
				IntPtr dest = bitmapGraphics.GetHdc();
				IntPtr source = browserGraphics.GetHdc();
				BitBlt(dest, 0, 0, width, height, source, xOffset, yOffset, SRCCOPY);
				bitmapGraphics.ReleaseHdc();
				browserGraphics.ReleaseHdc();
			}

			return returnBitmap;
		}

		[DllImport("gdi32.dll")]
		private static extern int BitBlt(
		  IntPtr hdcDest,     // handle to destination DC (device context)
		  int nXDest,         // x-coord of destination upper-left corner
		  int nYDest,         // y-coord of destination upper-left corner
		  int nWidth,         // width of destination rectangle
		  int nHeight,        // height of destination rectangle
		  IntPtr hdcSrc,      // handle to source DC
		  int nXSrc,          // x-coordinate of source upper-left corner
		  int nYSrc,          // y-coordinate of source upper-left corner
		  System.Int32 dwRop  // raster operation code
		  );

	}
}
