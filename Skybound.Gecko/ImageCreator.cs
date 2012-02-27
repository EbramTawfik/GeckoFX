using System;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using Gecko.DOM;
using GeckoFX.Microsoft;

namespace Gecko
{
	/// <summary>
	/// Creates Png images of webbrowser
	/// </summary>
	public class ImageCreator
	{
		GeckoWebBrowser m_browser;

		public ImageCreator(GeckoWebBrowser browser)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			m_browser = browser;
		}

		[Obsolete("Use CanvasGetPngImage",false)]
		public Bitmap CanvasGetBitmap(uint width, uint height)
		{
			return CanvasGetBitmap(0, 0, width, height);
		}
		
		/// <summary>
		/// Get a bitmap of the current browsers Window.
		/// Works on Visible or InVisible windows.
		/// Not captures plugin (Flash,etc...) windows
		/// </summary>
		/// <param name="xOffset"></param>
		/// <param name="yOffset"></param>
		/// <param name="width">Width length of returned bitmap in pixels</param>
		/// <param name="height">Height length of returned bitmap in pixels</param>
		/// <returns></returns>
		/// <throws>ArgumentException if width or height is zero</throws>
		[Obsolete("Use CanvasGetPngImage", false)]
		public Bitmap CanvasGetBitmap(uint xOffset, uint yOffset, uint width, uint height)
		{
			var bytes = CanvasGetPngImage(xOffset, yOffset, width, height);
			return (Bitmap)Bitmap.FromStream(new System.IO.MemoryStream(bytes));
		}

		/// <summary>
		/// Get byte array with png image of the current browsers Window.
		/// Wpf methods on windows platform don't use a Bitmap :-/
		/// Not captures plugin (Flash,etc...) windows
		/// </summary>
		/// <param name="xOffset"></param>
		/// <param name="yOffset"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		public byte[] CanvasGetPngImage(uint xOffset, uint yOffset, uint width, uint height)
		{
			if (width == 0)
				throw new ArgumentException("width");

			if (height == 0)
				throw new ArgumentException("height");

			// Use of the canvas technique was inspired by: the abduction! firefox plugin by Rowan Lewis
			// https://addons.mozilla.org/en-US/firefox/addon/abduction/

			// Some opertations fail without a proper JSContext.
			using (AutoJSContext jsContext = new AutoJSContext())
			{
				GeckoCanvasElement canvas = (GeckoCanvasElement)m_browser.Document.CreateElement("canvas");
				canvas.Width = width;
				canvas.Height = height;

				nsIDOMHTMLCanvasElement canvasPtr = (nsIDOMHTMLCanvasElement)canvas.DomObject;
				nsIDOMCanvasRenderingContext2D context;
				using (nsAString str = new nsAString("2d"))
				{
					context = (nsIDOMCanvasRenderingContext2D)canvasPtr.MozGetIPCContext(str);
				}

				using (nsAString color = new nsAString("rgb(255,255,255)"))
				{
					context.DrawWindow((nsIDOMWindow)m_browser.Window.DomWindow, xOffset, yOffset, width, height, color, 0);
				}

				string data = canvas.toDataURL("image/png");
				byte[] bytes = Convert.FromBase64String(data.Substring("data:image/png;base64,".Length));
				return bytes;
			}
		}

		public byte[] CanvasGetPngImage(uint width, uint height)
		{
			return CanvasGetPngImage(0, 0, width, height);
		}

		public byte[] GraphicsGetBitmapPng(int width, int height)
		{
			return GraphicsGetBitmapPng(0, 0, width, height);
		}

		public byte[] GraphicsGetBitmapPng(int xOffset, int yOffset, int width, int height)
		{
			Bitmap bmp = new Bitmap(width, height);
			using (Graphics g = m_browser.CreateGraphics())
			{       
				m_browser.DrawToBitmap(bmp, new Rectangle(xOffset, yOffset, width, height));
			}
			byte[] ret = null;
			using (var m = new MemoryStream())
			{
				bmp.Save(m, ImageFormat.Png);
				ret = m.ToArray();
			}
			return ret;
		}

		/// <summary>
		/// Capture whole WebBrowser window (Only on MS Windows Platform)
		/// </summary>
		/// <returns></returns>
		public byte[] CapturePng()
		{
			return CaptureWindowPng(m_browser.Handle);
		}

		/// <summary>
		/// Windows only window capture by handle
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		private static byte[] CaptureWindowPng(IntPtr handle)
		{
			// get te hDC of the target window
			IntPtr hdcSrc = User32.GetWindowDC(handle);
			// get the size
			User32.RECT windowRect = new User32.RECT();
			User32.GetWindowRect(handle,ref windowRect);
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
			User32.ReleaseDC(handle,hdcSrc);
			byte[] ret = null;
			// get a .NET image object for it
			using (Bitmap img = Image.FromHbitmap(hBitmap))
			{
				// free up the Bitmap object
				Gdi32.DeleteObject( hBitmap );
				// Saving to stream
				using (var m = new MemoryStream())
				{
					img.Save( m, ImageFormat.Png );
					ret = m.ToArray();
				}
			}
			return ret;
		}


	}
}
