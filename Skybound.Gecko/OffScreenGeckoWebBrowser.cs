#if GTK
using System.Drawing;
using System;

namespace Skybound.Gecko
{
	/// <summary>
	/// Used for offscreen capture of a web page.
	/// OffScreenGeckoWebBrowser doesn't always work in all X servers.
	/// For example it doesn't work with Xephyr.
	/// </summary>
	public class OffScreenGeckoWebBrowser : GeckoWebBrowser
	{		
		public OffScreenGeckoWebBrowser()
		{
			if (!Xpcom.IsMono)
				throw new NotImplementedException("Not currently implemented on Windows");
		
			// Create a special form of the GtkWrapper which doesn't reparent Gtk.Window into
			// a winform Control.
			m_wrapper = new GtkDotNet.GtkWrapperNoThread(new Gtk.Window(Gtk.WindowType.Popup));
		}
		
		/// <summary>
		/// Get a bitmap image, of given size, for the current web page. 
		/// </summary>		
		public Bitmap GetBitmap(int width, int height)
		{
			m_wrapper.BrowserWindow.Resize(width, height);
			m_wrapper.ProcessPendingGtkEvents();
			return m_wrapper.GetBitmap(width, height);
		}
	}
}
#endif