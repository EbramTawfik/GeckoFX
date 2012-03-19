namespace Gecko
{
	/// <summary>
	/// May be for future use (tabbed browser)
	/// </summary>
	public static class WindowMediator
	{
		private static ServiceWrapper<nsIWindowMediator> _windowMediator;

		static WindowMediator()
		{
			_windowMediator = new ServiceWrapper<nsIWindowMediator>( Contracts.WindowMediator );

			
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
		/// Get most recent window
		/// types:
		/// "navigator:browser"
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static nsIDOMWindow GetMostRecentWindow(string type)
		{
			return _windowMediator.Instance.GetMostRecentWindow( type );
		}
	}
}