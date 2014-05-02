using Gecko.Interop;
using System.Collections.Generic;

namespace Gecko
{
	/// <summary>
	/// May be for future use (tabbed browser)
	/// </summary>
	public static class WindowMediator
	{
		private static ComPtr<nsIWindowMediator> _windowMediator;

		static WindowMediator()
		{
			_windowMediator = Xpcom.GetService2<nsIWindowMediator>(Contracts.WindowMediator);			
		}

		public static void RegisterWindow(nsIXULWindow window)
		{
			_windowMediator.Instance.RegisterWindow(window);
		}


		public static void UnregisterWindow(nsIXULWindow window)
		{
			_windowMediator.Instance.UnregisterWindow( window );
		}
		/// <summary>
		/// Get most recent window.
		/// </summary>
		/// <param name="type">Window type. non-empty-string: for xul pages, should be equal to "windowtype" attribute of the root element.
		/// ""/null: for normal html pages.</param>
		/// <returns></returns>
		public static nsIDOMWindow GetMostRecentWindow(string type)
		{
			return _windowMediator.Instance.GetMostRecentWindow( type );
		}

		/// <summary>
		/// Gets the enumerator of all windows.
		/// </summary>
		/// <returns>The enumerator.</returns>
		/// <param name="type">Window type. non-empty-string: for xul pages, should be equal to "windowtype" attribute of the root element.
		/// ""/null: for normal html pages.</param>
		public static IEnumerator<GeckoWindow> GetEnumerator(string type)
		{
			return new Collections.GeckoEnumerator<GeckoWindow, nsIDOMWindow>(
				_windowMediator.Instance.GetEnumerator(type),
				x => new GeckoWindow(x));
		}
	}
}