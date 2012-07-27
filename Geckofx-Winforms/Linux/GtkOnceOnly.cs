using System.Diagnostics;
#if GTK
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
					
					GLib.ExceptionManager.UnhandledException += OnException;
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
}
#endif