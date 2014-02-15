using System;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using Gecko.DOM;

namespace Gecko
{
	/// <summary>
	/// Creates Png images of webbrowser
	/// </summary>
	public class ImageCreator
	{
		IGeckoWebBrowser m_browser;

		public ImageCreator(IGeckoWebBrowser browser)
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
			return (Bitmap)Image.FromStream(new System.IO.MemoryStream(bytes));
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

			throw new NotImplementedException("TypeError: ctx.drawWindow is not a function");

			// Use of the canvas technique was inspired by: the abduction! firefox plugin by Rowan Lewis
			// https://addons.mozilla.org/en-US/firefox/addon/abduction/

			uint flags = (uint)(nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_DO_NOT_FLUSH
							//| nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_DRAW_VIEW
							| nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_ASYNC_DECODE_IMAGES
							| nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_USE_WIDGET_LAYERS);
			string data;
			using (AutoJSContext context = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				context.EvaluateScript(string.Format(@"(function(canvas, ctx)
						{{
try {{
							canvas = document.createElement('canvas');
							canvas.width = {2};
							canvas.height = {3};
							ctx = canvas.getContext('2d');
							ctx.drawWindow(window, {0}, {1}, {2}, {3}, 'rgb(255,255,255)', {4});
							return canvas.toDataURL('image/png');
}} catch(e) {{ return e + '' }}
						}}
						)()", xOffset, yOffset, width, height, flags), (nsISupports)m_browser.Window.DomWindow, out data);
			}
			if (data == null || !data.StartsWith("data:image/png;base64,"))
				throw new InvalidOperationException();

			byte[] bytes = Convert.FromBase64String(data.Substring("data:image/png;base64,".Length));
			return bytes;
		}

		public byte[] CanvasGetPngImage(uint width, uint height)
		{
			return CanvasGetPngImage(0, 0, width, height);
		}

#if false // TODO move these method this into Geckofx-Winforms.
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
#endif
	}
}
