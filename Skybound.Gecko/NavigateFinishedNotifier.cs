using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gecko
{
	/// <summary>
	/// Emits NavigateFinished when a navigation has completed.
	/// </summary>
	public class NavigateFinishedNotifier
	{
		bool m_loadEventHandled;

		GeckoWebBrowser m_browser;

		public NavigateFinishedNotifier(GeckoWebBrowser browser)
		{
			m_browser = browser;
			m_browser.Navigating += (sender, e) => EmitNavigateFinishedWhenDone();
		}		
		
		/// <summary>
		/// This method is only intended to be used by unittests
		/// The normal way to know when a document has finished loading is to listen for the NavigateFinished event.
		/// </summary>
		public void BlockUntilNavigationFinished()
		{
			bool done = false;
			NavigateFinished += (sender, e) => done = true;
			while (!done)
			{
				Application.DoEvents();
				Application.RaiseIdle(new EventArgs());
			}
		}

		public event EventHandler NavigateFinished;

		private void EmitNavigateFinishedWhenDone()
		{
			// Geckofx OnNavigated occurs before document actually loaded.
			// work around this by idly checking if document has loaded.
			m_loadEventHandled = false;
			m_browser.Load += (s, e) => m_loadEventHandled = true;
			Application.Idle += HandleApplicationIdle;
		}

		private void HandleApplicationIdle(object sender, EventArgs e)
		{
			GeckoDocument document = (m_browser as GeckoWebBrowser).Document;
			// if body contains something assume navigation complete.
			if (!m_loadEventHandled || document == null || document.DocumentElement == null || document.ChildNodes.Count == 0)
				return;

			Application.Idle -= HandleApplicationIdle;

			if (NavigateFinished != null)
				NavigateFinished(this, new EventArgs());
		}
	}
}
