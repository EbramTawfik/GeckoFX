using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko
{
	/// <summary>
	/// Represents a DOM window.
	/// </summary>
	public class GeckoWindow
		:IDisposable 
	{
		private InstanceWrapper<nsIDOMWindow> _domWindow;

		private GeckoWindow(nsIDOMWindow window)
		{
			//Interop.ComDebug.WriteDebugInfo( window );
			_domWindow = new InstanceWrapper<nsIDOMWindow>( window );
		}

		~GeckoWindow()
		{
			Xpcom.DisposeObject( ref _domWindow );
		}

		public void Dispose()
		{
			Xpcom.DisposeObject( ref _domWindow );
			GC.SuppressFinalize( this );
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
			get
			{
				var utils = Xpcom.QueryInterface<nsIDOMWindowUtils>( DomWindow );
				return utils.Wrap( WindowUtils.Create );
			}
		}
		
		public static GeckoWindow Create(nsIDOMWindow window)
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
			get { return _domWindow.Instance.GetParentAttribute().Wrap( Create ); }
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
			get { return _domWindow.Instance.GetTopAttribute().Wrap( Create ); }
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

		public GeckoWindowCollection Frames
		{
			get { return new GeckoWindowCollection(_domWindow.Instance.GetFramesAttribute()); }
		}

		public IntPtr JSContext
		{
			get
			{
				return GlobalJSContextHolder.GetJSContextForDomWindow(_domWindow.Instance);
			}
		}
	}


	public static class GeckoWindowExtension
	{
		public static bool IsTopWindow( this GeckoWindow geckoWindow )
		{
			if ( geckoWindow == null ) return true;
			var top = geckoWindow.Top;
			if ( top == null ) return true;
			return top.DomWindow.GetHashCode() == geckoWindow.DomWindow.GetHashCode();
		}
	}
}