namespace Gecko
{
	/// <summary>
	/// Represents a DOM window.
	/// </summary>
	public class GeckoWindow
	{
		private GeckoWindow(nsIDOMWindow window)
		{
			_DomWindow = window;
		}
		
		/// <summary>
		/// Gets the underlying unmanaged DOM object.
		/// </summary>
		public nsIDOMWindow DomWindow
		{
			get { return _DomWindow; }
		}
		nsIDOMWindow _DomWindow;
		
		internal static GeckoWindow Create(nsIDOMWindow window)
		{
			return (window == null) ? null : new GeckoWindow(window);
		}
		
		/// <summary>
		/// Gets the document displayed in the window.
		/// </summary>
		public GeckoDocument Document
		{
			get { return GeckoDocument.Create((nsIDOMHTMLDocument)_DomWindow.GetDocumentAttribute()); }
		}
		
		/// <summary>
		/// Gets the parent window of this one.
		/// </summary>
		public GeckoWindow Parent
		{
			get { return GeckoWindow.Create((nsIDOMWindow)_DomWindow.GetParentAttribute()); }
		}

		public int ScrollX
		{
			get { return _DomWindow.GetScrollXAttribute(); }
		}
		
		public int ScrollY
		{
			get { return _DomWindow.GetScrollYAttribute(); }
		}

		public void ScrollTo(int xScroll, int yScroll)
		{
			_DomWindow.ScrollTo(xScroll, yScroll);
		}

		public void ScrollBy(int xScrollDif, int yScrollDif)
		{
			_DomWindow.ScrollBy(xScrollDif, yScrollDif);
		}

		public void ScrollByLines(int numLines)
		{
			_DomWindow.ScrollByLines(numLines);
		}

		public void ScrollByPages(int numPages)
		{
			_DomWindow.ScrollByPages(numPages);
		}

		public void SizeToContent()
		{
			_DomWindow.SizeToContent();
		}

		public float TextZoom
		{
			get { return _DomWindow.GetTextZoomAttribute(); }
			set { _DomWindow.SetTextZoomAttribute(value); }
		}
		
		public GeckoWindow Top
		{
			get { return GeckoWindow.Create((nsIDOMWindow)_DomWindow.GetTopAttribute()); }
		}
		
		public string Name
		{
			get { return nsString.Get(_DomWindow.GetNameAttribute); }
			set { nsString.Set(_DomWindow.SetNameAttribute, value); }
		}
		
		public void Print()
		{
			nsIWebBrowserPrint print = Xpcom.QueryInterface<nsIWebBrowserPrint>(this.DomWindow);
			
			print.Print(null, null);
		}
		
		public GeckoSelection Selection
		{
			get 
			{
				if (_DomWindow.GetSelection() == null)
					return null;

				return new GeckoSelection(this._DomWindow.GetSelection());
			}
		}
	}
}