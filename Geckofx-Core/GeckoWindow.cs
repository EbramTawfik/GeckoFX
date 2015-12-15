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
		:IEquatable<GeckoWindow>,IDisposable 
	{
		private ComPtr<nsIDOMWindow> _domWindow;

		#region ctor & dtor
		public GeckoWindow(nsIDOMWindow window)
		{
			//Interop.ComDebug.WriteDebugInfo( window );
			_domWindow = new ComPtr<nsIDOMWindow>( window );
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
		#endregion

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

		
		/// <summary>
		/// Gets the document displayed in the window.
		/// </summary>
		public GeckoDomDocument Document
		{
			get
			{
                return new WebIDL.Window((nsISupports)_domWindow.Instance).Document.Wrap(GeckoDomDocument.CreateDomDocumentWraper);
			}
		}
		
		/// <summary>
		/// Gets the parent window of this one.
		/// </summary>
		public GeckoWindow Parent
		{
			get { return new WebIDL.Window((nsISupports)_domWindow.Instance).Parent.Wrap( x => new GeckoWindow( x ) ); }
		}

		public int ScrollX
		{
			get { return new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollX; }
		}
		
		public int ScrollY
		{
            get { return new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollY; }
		}

		public void ScrollTo(int xScroll, int yScroll)
		{
            new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollTo(xScroll, yScroll);
		}

		public void ScrollBy(int xScrollDif, int yScrollDif)
		{
            new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollBy(xScrollDif, yScrollDif);
		}

		public void ScrollByLines(int numLines)
		{
            new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollByLines(numLines, null);
		}

		public void ScrollByPages(int numPages)
		{
            new WebIDL.Window((nsISupports)_domWindow.Instance).ScrollByPages(numPages, null);
		}

		public void SizeToContent()
		{
            new WebIDL.Window((nsISupports)_domWindow.Instance).SizeToContent();
		}

// prop no longer exist in gecko 45        
#if false
		public float TextZoom
		{
			get { return _domWindow.Instance.GetTextZoomAttribute(); }
			set { _domWindow.Instance.SetTextZoomAttribute( value ); }
		}
#endif
		
		public GeckoWindow Top
		{
			get { return new WebIDL.Window((nsISupports)_domWindow.Instance).Top.Wrap( x => new GeckoWindow( x ) ); }
		}
		
		public string Name
		{
		    get
		    {
		        return new WebIDL.Window((nsISupports) _domWindow.Instance).Name.ToString();
		    }
			set { nsString.Set((s) => { new WebIDL.Window((nsISupports) _domWindow.Instance).Name = s; }, value ); }
		}
		
		public void Print()
		{
			nsIWebBrowserPrint print = Xpcom.QueryInterface<nsIWebBrowserPrint>( _domWindow.Instance );
			
			try
			{
				print.Print(null, null);
			}
			catch(COMException e)
			{
				//NS_ERROR_ABORT means user cancelled the printing, not really an error.
				if (e.ErrorCode != GeckoError.NS_ERROR_ABORT)
					throw;
			}

			Marshal.ReleaseComObject( print );
		}
		
		public GeckoSelection Selection
		{
            get { return GeckoSelection.Create(new WebIDL.Window((nsISupports)_domWindow.Instance).GetSelection()); }
		}

        // The WebIDL Window interfaces doesn't seem to have a Frames apptribute that returns a WindowCollection (rather just a window proxy? is it QI-able?)
#if false
		public GeckoWindowCollection Frames
		{
			get { return new GeckoWindowCollection(_domWindow.Instance.GetFramesAttribute()); }
		}
#endif

		public IntPtr JSContext
		{
			get
			{
				return GlobalJSContextHolder.GetJSContextForDomWindow(_domWindow.Instance);
			}
		}

		public bool Equals(GeckoWindow other)
		{
			if (ReferenceEquals(this, other)) return true;
			if (ReferenceEquals(other, null)) return false;
			return _domWindow.Instance.GetHashCode() == other._domWindow.Instance.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			if (ReferenceEquals(obj, null)) return false;
			return _domWindow.Instance.GetHashCode() == ((GeckoWindow)obj)._domWindow.Instance.GetHashCode();
		}

		public override int GetHashCode()
		{
// ReSharper disable once NonReadonlyFieldInGetHashCode
			return _domWindow.Instance.GetHashCode();
		}

	}


	public static class GeckoWindowExtension
	{
		public static bool IsTopWindow( this GeckoWindow geckoWindow )
		{
			if ( geckoWindow == null ) return true;
			using (var top = geckoWindow.Top)
			{
				if (top == null)
					return true;
				return top.DomWindow.GetHashCode() == geckoWindow.DomWindow.GetHashCode();
			}
		}
	}
}