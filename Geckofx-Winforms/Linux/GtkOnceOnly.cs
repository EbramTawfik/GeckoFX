using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gdk;

#if GTK
namespace GtkDotNet
{
	public static class GtkOnceOnly
	{
		public static Filter Filter = new Filter();

		public static void Init()
		{
			lock(m_initedOnce)
			{
				if (((bool)m_initedOnce) == false)
				{
					Gtk.Application.Init();
					m_initedOnce = true;
					
					// UnhandledException event doesn't seem to be sufficient when running in kde.
					Gdk.Error.TrapPush();
					
					GLib.ExceptionManager.UnhandledException += OnException;

                    if (Gecko.GeckoWebBrowser.GtkDontUseSetInputFocus)
					    System.Windows.Forms.Application.AddMessageFilter(Filter);
                }
			}
		}

		static void OnException(GLib.UnhandledExceptionArgs args)
		{
			Debug.WriteLine("Glib error error {0}", args.ExceptionObject.ToString());
			args.ExitApplication = false;
		}
		/// <summary>
		/// Stores if gtk has been initizlized.
		/// </summary>
		internal static object m_initedOnce = false;	
	}

    public class Filter : System.Windows.Forms.IMessageFilter
    {
        public GtkKeyboardAwareReparentingWrapperNoThread Active { get; set; }
        public GtkKeyboardAwareReparentingWrapperNoThread LastActive { get; set; }
        public Form LastActiveForm { get; set; }

        public bool PreFilterMessage(ref Message m)
        {
            const int WM_ACTIVATE = 0x06;
            const int WM_LBUTTONDOWN = 0x201;
#if LOGGING
            const int WM_IDLE = 0x121;
            // Don't log idle events.
            if (m.Msg != WM_IDLE)
                System.Console.WriteLine(m);
#endif

            // Deactivate
            if (Active != null && m.Msg == WM_ACTIVATE && m.WParam.ToInt32() == 0)
                Active.RemoveInputFocus();

            // Activiate
            if (Active != null && m.Msg == WM_ACTIVATE && m.WParam.ToInt32() == 1)
                Active.SetInputFocus();

            // Mouse Click. (on a winform control - not gtk window)
            if (Active != null && m.Msg == WM_LBUTTONDOWN)
                Active.RemoveInputFocus();

            return false;
        }
    }
}
#endif
