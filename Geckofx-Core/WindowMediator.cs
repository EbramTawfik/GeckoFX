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

        //For debugging window leak
        //private static int _windowCount = 0;

        static WindowMediator()
        {
            _windowMediator = Xpcom.GetService2<nsIWindowMediator>(Contracts.WindowMediator);
        }

        /// <summary>
        /// Set this to true to disable WindowMediator.
        /// This saves a small amount of memory each time a GeckoWebBrowser control is created.
        /// </summary>
        /// <value></value>
        public static bool Disable { get; set; }

        public static void Shutdown()
        {
            if (_windowMediator != null)
                _windowMediator.Dispose();
            _windowMediator = null;
        }

        public static void RegisterWindow(nsIXULWindow window)
        {
            if (Disable)
                return;

            _windowMediator.Instance.RegisterWindow(window);
            //_windowCount ++;
        }


        public static void UnregisterWindow(nsIXULWindow window)
        {
            if (Disable)
                return;

            _windowMediator.Instance.UnregisterWindow(window);
            //_windowCount --;
        }

        /// <summary>
        /// Get most recent window.
        /// </summary>
        /// <param name="type">Window type. non-empty-string: for xul pages, should be equal to "windowtype" attribute of the root element.
        /// ""/null: for normal html pages.</param>
        /// <returns></returns>
        public static nsIDOMWindow GetMostRecentWindow(string type)
        {
            if (Disable)
                return null;

            return _windowMediator.Instance.GetMostRecentWindow(type);
        }

        /// <summary>
        /// Gets the enumerator of all windows.
        /// </summary>
        /// <returns>The enumerator.</returns>
        /// <param name="type">Window type. non-empty-string: for xul pages, should be equal to "windowtype" attribute of the root element.
        /// ""/null: for normal html pages.</param>
        public static IEnumerator<GeckoWindow> GetEnumerator(string type)
        {
            if (Disable)
                return null;

            return new Collections.GeckoEnumerator<GeckoWindow, nsIDOMWindow>(
                _windowMediator.Instance.GetEnumerator(type),
                x => new GeckoWindow(x));
        }
    }
}