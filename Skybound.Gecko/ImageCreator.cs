using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace Gecko
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

		public Bitmap GetBitmap(uint width, uint height)
		{
			return GetBitmap(0, 0, width, height);
		}
		
		/// <summary>
		/// Get a bitmap of the current browsers Window.
		/// Works on Visible or InVisible windows.
		/// </summary>
		/// <param name="xOffset"></param>
		/// <param name="yOffset"></param>
		/// <param name="width">Width length of returned bitmap in pixels</param>
		/// <param name="height">Height length of returned bitmap in pixels</param>
		/// <returns></returns>
		/// <throws>ArgumentException if width or height is zero</throws>
		public Bitmap GetBitmap(uint xOffset, uint yOffset, uint width, uint height)
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
				return (Bitmap)Bitmap.FromStream(new System.IO.MemoryStream(bytes));				
			}
			
		}
	}
}
