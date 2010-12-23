using Gdk;
using Gtk;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GtkDotNet
{
	/// <summary>
	/// Allows embeding of a Gtk Window in Winforms control. The gtk event loop is run using  Winform idle processing.
	/// </summary>
	public class GtkWrapperNoThread
	{
		/// <summary>
		/// The Gtk window which is embeded into m_parent.
		/// </summary>
		public Gtk.Window m_popupWindow;

		/// <summary>
		/// The Winform control that m_popupWindow is reparented into.
		/// </summary>
		protected Control m_parent;

		/// <summary>
		/// Gdk wrapper created from m_parent handle.
		/// </summary>
		protected Gdk.Window m_gdkWrapperOfForm;

		/// <summary>
		/// Stores if gtk has been initizlized.
		/// </summary>
		protected bool m_initedOnce = false;

		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// parent is winform control which the popupWindow is embeded into.
		/// </summary>
		public GtkWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent)
		{
			if (popupWindow.Type != Gtk.WindowType.Popup)
			{
				throw new ArgumentException("Gtk Window should be of type Popup.");
			}

			popupWindow.KeyPressEvent += HandlePopupWindowKeyPressEvent;

			m_parent = parent;
			m_popupWindow = popupWindow;
			m_parent.HandleCreated += HandleParentCreated;
			m_parent.Resize += HandleParentResize;
		}

		void HandlePopupWindowKeyPressEvent (object o, Gtk.KeyPressEventArgs args)
		{

			// TODO FIXME: this is a proof of concept key forwarding, this will need more
			// work to deal with all keypresses. (pressing backspace currently crashes)

			if (m_popupWindow.HasFocus)
			{
				m_parent.Focus();
				m_parent.Select();
			}
			System.Windows.Forms.SendKeys.Send(((char)args.Event.KeyValue).ToString());
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

		void HandleParentCreated(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Idle += (senderArg, eventArg) =>
			{
				Init();
				ProcessPendingGtkEvents();
			};
		}

		public void Init()
		{
			if (m_initedOnce)
				return;

			lock(this)
			{
				if (!m_initedOnce)
				{
					Gtk.Application.Init();
					EmbedWidgetIntoWinFormPanel();
					m_initedOnce = true;
				}
			}
		}

		internal void ProcessPendingGtkEvents()
		{
			while (Gtk.Application.EventsPending()) {
				Gtk.Application.RunIteration(false);
			}
		}

		public FilterReturn FilterFunc (IntPtr xevent, Event evnt)
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

		protected void EmbedWidgetIntoWinFormPanel()
		{
			m_popupWindow.ShowNow();
			m_popupWindow.Move(-5000, -5000);
			while (m_popupWindow.GdkWindow == null)
			{
				ProcessPendingGtkEvents();
			}

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
	}
}

