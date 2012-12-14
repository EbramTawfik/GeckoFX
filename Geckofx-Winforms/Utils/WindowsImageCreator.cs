using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using GeckoFX.Microsoft;

namespace Gecko.Utils
{
#if GTK
#else
	public static class WindowsImageCreator
	{
		/// <summary>
		/// Windows only window capture by handle
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public static byte[] WindowsCapturePng(IntPtr handle)
		{
			// get te hDC of the target window
			IntPtr hdcSrc = User32.GetWindowDC(handle);
			// get the size
			User32.RECT windowRect = new User32.RECT();
			User32.GetWindowRect(handle, ref windowRect);
			int width = windowRect.right - windowRect.left;
			int height = windowRect.bottom - windowRect.top;
			// create a device context we can copy to
			IntPtr hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);
			// create a bitmap we can copy it to,
			// using GetDeviceCaps to get the width/height
			IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, width, height);
			// select the bitmap object
			IntPtr hOld = Gdi32.SelectObject(hdcDest, hBitmap);
			// bitblt over
			Gdi32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, Gdi32.SRCCOPY);
			// restore selection
			Gdi32.SelectObject(hdcDest, hOld);
			// clean up 
			Gdi32.DeleteDC(hdcDest);
			User32.ReleaseDC(handle, hdcSrc);
			byte[] ret = null;
			// calling  Image.FromHbitmap cause error when hBitmap is not exists
			try
			{
				// get a .NET image object for it
				using ( Bitmap img = Image.FromHbitmap( hBitmap ) )
				{
					// Saving to stream
					using ( var m = new MemoryStream(500) )
					{
						img.Save( m, ImageFormat.Png );
						ret = m.ToArray();
					}
				}
			}
			catch ( Exception )
			{

			}finally
			{
				// free up the Bitmap object
				Gdi32.DeleteObject( hBitmap );
			}
			
			return ret;
		}

		/// <summary>
		/// Capture whole WebBrowser window (Only on MS Windows Platform)
		/// </summary>
		/// <returns></returns>
		public static byte[] CapturePng(this GeckoWebBrowser browser)
		{
			return WindowsCapturePng(browser.Handle);
		}
	}

#endif
}
