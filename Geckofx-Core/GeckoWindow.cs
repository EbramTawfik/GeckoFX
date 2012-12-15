using System.Runtime.InteropServices;
using Gecko.DOM;
namespace Gecko
{
	/// <summary>
	/// Represents a DOM window.
	/// </summary>
	public class GeckoWindow
	{
		private InstanceWrapper<nsIDOMWindow> _domWindow;

		public GeckoWindow(nsIDOMWindow window)
		{
			int hashCode = window.GetHashCode();
			int refCount = Interop.ComDebug.GetComRefCount( window );
			int rcwCount = Interop.ComDebug.GetRcwRefCount( window );
			System.Console.WriteLine( "{0} - ref:{1},rcw:{2}", hashCode, refCount, rcwCount );
			_domWindow = new InstanceWrapper<nsIDOMWindow>( window );
			
		}

		~GeckoWindow()
		{
			Xpcom.DisposeObject( ref _domWindow );
		}
		
		/// <summary>
		/// Gets the underlying unmanaged DOM object.
		/// </summary>
		public nsIDOMWindow DomWindow
		{
			get { return _domWindow.Instance; }
		}

		public WindowUtils WindowUtils 
		{
			get { return new WindowUtils(Xpcom.QueryInterface<nsIDOMWindowUtils>(DomWindow)); }
		}
		
		internal static GeckoWindow Create(nsIDOMWindow window)
		{
			return (window == null) ? null : new GeckoWindow(window);
		}
		
		/// <summary>
		/// Gets the document displayed in the window.
		/// </summary>
		public GeckoDocument Document
		{
			get { return GeckoDocument.Create( ( nsIDOMHTMLDocument ) _domWindow.Instance.GetDocumentAttribute() ); }
		}
		
		/// <summary>
		/// Gets the parent window of this one.
		/// </summary>
		public GeckoWindow Parent
		{
			get { return GeckoWindow.Create( ( nsIDOMWindow ) _domWindow.Instance.GetParentAttribute() ); }
		}

		public int ScrollX
		{
			get { return _domWindow.Instance.GetScrollXAttribute(); }
		}
		
		public int ScrollY
		{
			get { return _domWindow.Instance.GetScrollYAttribute(); }
		}

		public void ScrollTo(int xScroll, int yScroll)
		{
			_domWindow.Instance.ScrollTo( xScroll, yScroll );
		}

		public void ScrollBy(int xScrollDif, int yScrollDif)
		{
			_domWindow.Instance.ScrollBy( xScrollDif, yScrollDif );
		}

		public void ScrollByLines(int numLines)
		{
			_domWindow.Instance.ScrollByLines( numLines );
		}

		public void ScrollByPages(int numPages)
		{
			_domWindow.Instance.ScrollByPages( numPages );
		}

		public void SizeToContent()
		{
			_domWindow.Instance.SizeToContent();
		}

		public float TextZoom
		{
			get { return _domWindow.Instance.GetTextZoomAttribute(); }
			set { _domWindow.Instance.SetTextZoomAttribute( value ); }
		}
		
		public GeckoWindow Top
		{
			get { return GeckoWindow.Create( _domWindow.Instance.GetTopAttribute() ); }
		}
		
		public string Name
		{
			get { return nsString.Get( _domWindow.Instance.GetNameAttribute ); }
			set { nsString.Set( _domWindow.Instance.SetNameAttribute, value ); }
		}
		
		public void Print()
		{
			nsIWebBrowserPrint print = Xpcom.QueryInterface<nsIWebBrowserPrint>( _domWindow.Instance );
			
			print.Print(null, null);

			Marshal.ReleaseComObject( print );
		}
		
		public GeckoSelection Selection
		{
			get { return GeckoSelection.Create( _domWindow.Instance.GetSelection() ); }
		}
	}
}