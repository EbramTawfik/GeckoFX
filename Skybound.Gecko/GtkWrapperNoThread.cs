using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gdk;
using Gtk;

namespace GtkDotNet
{
	public static class GtkOnceOnly
	{
		public static void Init()
		{
			lock(m_initedOnce)
			{
				if (((bool)m_initedOnce) == false)
				{
					Gtk.Application.Init();
					m_initedOnce = true;
				}
			}
		}
		/// <summary>
		/// Stores if gtk has been initizlized.
		/// </summary>
		internal static object m_initedOnce = false;	
	}
		
	public class GtkReparentingWrapperNoThread : GtkWrapperNoThread
	{
		/// <summary>
		/// The Winform control that m_popupWindow is reparented into.
		/// </summary>
		protected Control m_parent;
		
		/// <summary>
		/// Gdk wrapper created from m_parent handle.
		/// </summary>
		protected Gdk.Window m_gdkWrapperOfForm;
		
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// parent is winform control which the popupWindow is embeded into.
		/// </summary>
		public GtkReparentingWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent)
		{
			if (popupWindow.Type != Gtk.WindowType.Popup)
			{
				throw new ArgumentException("Gtk Window should be of type Popup.");
			}

			m_parent = parent;
			m_popupWindow = popupWindow;
			m_parent.HandleCreated += HandleParentCreated;
			m_parent.Resize += HandleParentResize;
		}
		
		public override void Init()
		{
			base.Init();
						
			EmbedWidgetIntoWinFormPanel();
		}
		
		void HandleParentCreated(object sender, EventArgs e)
		{			
			System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;
		}
		
		void HandleParentResize(object sender, EventArgs e)
		{				
			m_parent.Invalidate(true);

			if (m_popupWindow != null)
			{
				m_popupWindow.SetSizeRequest(m_parent.Width, m_parent.Height);
				m_popupWindow.QueueDraw();
			}
		}
		
		protected void EmbedWidgetIntoWinFormPanel()
		{						
			// Wraps the panel native (X) window handle in a GdkWrapper
			m_gdkWrapperOfForm = Gdk.Window.ForeignNewForDisplay(Gdk.Display.Default, (uint)m_parent.Handle);

			// get low level access to x11 events
			Gdk.Window.AddFilterForAll(FilterFunc);
			System.Windows.Forms.Application.DoEvents();
			ProcessPendingGtkEvents();

			// embed m_popupWindow into winform (m_parent)
			m_popupWindow.GdkWindow.Reparent(m_gdkWrapperOfForm, 0, 0);
			ProcessPendingGtkEvents();
		}
		
		private FilterReturn FilterFunc (IntPtr xevent, Event evnt)
		{
			if (xevent == IntPtr.Zero)
				return FilterReturn.Continue;

			var e = (X11.XEvent)Marshal.PtrToStructure(xevent, typeof(X11.XEvent));

			// Dropping these events is non standard but so is embeding a Gtk into
			// a X11 Window.
			if (e.type == X11.XEventName.FocusOut ||
				e.type == X11.XEventName.LeaveNotify)
			{
				return FilterReturn.Remove;
			}

			// Ensure Mouse clicks and Button go to the right place
			if (e.type == X11.XEventName.ButtonPress ||
				e.type == X11.XEventName.KeyPress)
			{
				// TODO: possibly cancel any tooltip windows.

				this.m_parent.Focus();
				return FilterReturn.Continue;
			}

			// Everything else just process as normal
			return FilterReturn.Continue;
		}
		
		protected override void Cleanup()
		{			
			// TODO: reparent back into m_popupWindow before destroying Window.
			
			base.Cleanup();
		}
	}
	
	/// <summary>
	/// Allows embeding of a Gtk Window in Winforms control. The gtk event loop is run using  Winform idle processing.
	/// </summary>
	public class GtkWrapperNoThread : IDisposable
	{
		/// <summary>
		/// The Gtk window which is embeded into m_parent.
		/// </summary>
		protected Gtk.Window m_popupWindow;
		
		/// <summary>
		/// stores if the passed popup windows has been created.
		/// </summary>
		protected bool m_popupWindowCreated = false;
		
		protected GtkWrapperNoThread()
		{
		}
		
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// </summary>
		public GtkWrapperNoThread(Gtk.Window popupWindow)
		{
			if (popupWindow.Type != Gtk.WindowType.Popup)
			{
				throw new ArgumentException("Gtk Window should be of type Popup.");
			}
			
			m_popupWindow = popupWindow;	
			
			System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;			
		}

		protected void HandleSystemWindowsFormsApplicationIdle(object sender, EventArgs e)
		{
			Init();
			ProcessPendingGtkEvents();
		}

		protected virtual void Cleanup()
		{							
			System.Windows.Forms.Application.Idle -= HandleSystemWindowsFormsApplicationIdle;
			m_popupWindow.Destroy();
		}

		#region IDisposable implementation
		public void Dispose()
		{
			Cleanup();
		}
		#endregion
		
		public Gtk.Window BrowserWindow
		{
			get { return m_popupWindow; }	
		}
				
		protected Gdk.Pixbuf GetPixbufOfWebBrowser(int width, int height)
		{				
			return Pixbuf.FromDrawable(BrowserWindow.GdkWindow, BrowserWindow.Colormap, 0, 0, 0, 0, width, height);			
		}
		
		internal Bitmap GetBitmap(int width, int height)
		{			
			Gdk.Pixbuf pb = GetPixbufOfWebBrowser(width, height);
			byte[] buffer = pb.SaveToBuffer("bmp");			
			MemoryStream s = new MemoryStream(buffer);
			
			return new Bitmap(s);			
		}

		public virtual void Init()
		{
			if (m_popupWindowCreated)
				return;
			
			GtkOnceOnly.Init();
			
			lock(this)
			{
				if (m_popupWindowCreated == true)
					return;
				
				CreatePopWindowOffScreen();				
				m_popupWindowCreated = true;
			}
		}

		internal void ProcessPendingGtkEvents()
		{
			try
			{
				while (Gtk.Application.EventsPending()) {
					Gtk.Application.RunIteration(false);
				}
			}catch(Exception e)
			{
				// Ignore any exceptions to improve stablity.
				Debug.WriteLine(e);
			}			
		}

		protected void CreatePopWindowOffScreen()
		{
			m_popupWindow.ShowNow();
			m_popupWindow.DoubleBuffered = false;
			m_popupWindow.Move(-5000, -5000);
			
			while (m_popupWindow.GdkWindow == null)
			{
				ProcessPendingGtkEvents();
			}
		}
	}
}

