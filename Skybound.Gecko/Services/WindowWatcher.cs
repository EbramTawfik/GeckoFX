using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Services
{
	public static class WindowWatcher
	{
		private static ServiceWrapper<nsIWindowWatcher> _watcher;

		static WindowWatcher()
		{
			_watcher = new ServiceWrapper<nsIWindowWatcher>( Contracts.WindowWatcher );
		}

		public static nsIWindowCreator2 WindowCreator
		{
			set { _watcher.Instance.SetWindowCreator(value); }
		}

		public static GeckoWindow ActiveWindow
		{
			get { return GeckoWindow.Create( _watcher.Instance.GetActiveWindowAttribute() ); }
			set { _watcher.Instance.SetActiveWindowAttribute( value.DomWindow ); }
		}

		public static IEnumerator<GeckoWindow> GetWindowEnumerator()
		{
			return new Collections.GeckoEnumerator<GeckoWindow, nsIDOMWindow>(
				_watcher.Instance.GetWindowEnumerator(),
				GeckoWindow.Create );
		}


	}
}
