using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//EventHandlerList http://msdn.microsoft.com/en-us/library/system.componentmodel.eventhandlerlist.aspx
//Generic EventHandler http://msdn.microsoft.com/en-us/library/db0etb8x.aspx
//C# 3.0 in a nutshell http://books.google.com/books?id=_Y0rWd-Q2xkC&pg=PA113&lpg=PA113&dq=readonly+field+eventargs&source=bl&ots=R8CCSaWH-j&sig=s6ImztjXLnI2rrL-usLfoGmVR8g&hl=en&sa=X&ei=EctAT5baOM3Zsga9ocDYBA&ved=0CFkQ6AEwBw

// I have placed to readonly fields only basic .NET Framework objects - value types,strings, Uri's
namespace Gecko
{
	partial class GeckoWebBrowser
	{
		#region Event Keys
		// Navigation
		private static readonly object NavigatingEvent = new object();
		private static readonly object NavigatedEvent = new object();
		private static readonly object DocumentCompletedEvent = new object();
		private static readonly object CanGoBackChangedEvent = new object();
		private static readonly object CanGoForwardChangedEvent = new object();
		// ProgressChanged
		private static readonly object ProgressChangedEvent = new object();
		// History
		private static readonly object HistoryNewEntryEvent = new object();
		private static readonly object HistoryGoBackEvent = new object();
		private static readonly object HistoryGoForwardEvent = new object();
		private static readonly object HistoryReloadEvent = new object();
		private static readonly object HistoryGotoIndexEvent = new object();
		private static readonly object HistoryPurgeEvent = new object();
		// Windows
		private static readonly object CreateWindowEvent = new object();
		private static readonly object CreateWindow2Event = new object();
		private static readonly object WindowSetBoundsEvent = new object();
		// StatusTextChanged
		private static readonly object StatusTextChangedEvent = new object();
		// DocumentTitleChanged
		private static readonly object DocumentTitleChangedEvent = new object();
		// ShowContextMenu
		private static readonly object ShowContextMenuEvent = new object();
		// ObserveHttpModifyRequest
		private static readonly object ObserveHttpModifyRequestEvent = new object();
		// Dom
		private static readonly object DomKeyDownEvent = new object();
		private static readonly object DomKeyUpEvent = new object();
		private static readonly object DomKeyPressEvent = new object();
		private static readonly object DomMouseDownEvent = new object();
		private static readonly object DomMouseUpEvent = new object();
		private static readonly object DomMouseOverEvent = new object();
		private static readonly object DomMouseOutEvent = new object();
		private static readonly object DomMouseMoveEvent = new object();
		private static readonly object DomContextMenuEvent = new object();
		private static readonly object DomMouseScrollEvent = new object();
		private static readonly object DomSubmitEvent = new object();
		private static readonly object DomCompositionStartEvent = new object();
		private static readonly object DomCompositionEndEvent = new object();
		private static readonly object DomFocusEvent = new object();
		private static readonly object DomBlurEvent = new object();
		private static readonly object LoadEvent = new object();
		private static readonly object DomContentChangedEvent = new object();
		private static readonly object DomClickEvent = new object();
		private static readonly object DomDoubleClickEvent = new object();
		#endregion

		#region Navigation events

		#region public event EventHandler<GeckoNavigatingEventArgs> Navigating

		/// <summary>
		/// Occurs before the browser navigates to a new page.
		/// </summary>
		[Category( "Navigation" )]
		[Description( "Occurs before the browser navigates to a new page." )]
		public event EventHandler<GeckoNavigatingEventArgs> Navigating
		{
			add { Events.AddHandler( NavigatingEvent, value ); }
			remove { Events.RemoveHandler( NavigatingEvent, value ); }
		}

		/// <summary>Raises the <see cref="Navigating"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnNavigating( GeckoNavigatingEventArgs e )
		{
			var evnt = ( ( EventHandler<GeckoNavigatingEventArgs> ) Events[ NavigatingEvent ] );
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler<GeckoNavigatedEventArgs> Navigated

		/// <summary>
		/// Occurs after the browser has navigated to a new page.
		/// </summary>
		[Category( "Navigation" )]
		[Description( "Occurs after the browser has navigated to a new page." )]
		public event EventHandler<GeckoNavigatedEventArgs> Navigated
		{
			add { Events.AddHandler( NavigatedEvent, value ); }
			remove { Events.RemoveHandler( NavigatedEvent, value ); }
		}

		/// <summary>Raises the <see cref="Navigated"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnNavigated( GeckoNavigatedEventArgs e )
		{
			var evnt = ( EventHandler<GeckoNavigatedEventArgs> ) Events[ NavigatedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler DocumentCompleted

		/// <summary>
		/// Occurs after the browser has finished parsing a new page and updated the <see cref="Document"/> property.
		/// </summary>
		[Category( "Navigation" )]
		[Description( "Occurs after the browser has finished parsing a new page and updated the Document property." )]
		public event EventHandler DocumentCompleted
		{
			add { Events.AddHandler( DocumentCompletedEvent, value ); }
			remove { Events.RemoveHandler( DocumentCompletedEvent, value ); }
		}

		/// <summary>Raises the <see cref="DocumentCompleted"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDocumentCompleted( EventArgs e )
		{
			var evnt = ( EventHandler ) Events[ DocumentCompletedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler CanGoBackChanged

		/// <summary>
		/// Occurs when the value of the <see cref="CanGoBack"/> property is changed.
		/// </summary>
		[Category( "Property Changed" )]
		[Description( "Occurs when the value of the CanGoBack property is changed." )]
		public event EventHandler CanGoBackChanged
		{
			add { Events.AddHandler( CanGoBackChangedEvent, value ); }
			remove { Events.RemoveHandler( CanGoBackChangedEvent, value ); }
		}

		/// <summary>Raises the <see cref="CanGoBackChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnCanGoBackChanged( EventArgs e )
		{
			var evnt = ( EventHandler ) Events[ CanGoBackChangedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler CanGoForwardChanged

		/// <summary>
		/// Occurs when the value of the <see cref="CanGoForward"/> property is changed.
		/// </summary>
		[Category( "Property Changed" )]
		[Description( "Occurs when the value of the CanGoForward property is changed." )]
		public event EventHandler CanGoForwardChanged
		{
			add { Events.AddHandler( CanGoForwardChangedEvent, value ); }
			remove { Events.RemoveHandler( CanGoForwardChangedEvent, value ); }
		}

		/// <summary>Raises the <see cref="CanGoForwardChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnCanGoForwardChanged( EventArgs e )
		{
			var evnt = ( EventHandler ) Events[ CanGoForwardChangedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#endregion

		#region History events

		#region public event EventHandler<GeckoHistoryEventArgs> HistoryNewEntry

		[Category( "History" )]
		public event EventHandler<GeckoHistoryEventArgs> HistoryNewEntry
		{
			add { Events.AddHandler( HistoryNewEntryEvent, value ); }
			remove { Events.RemoveHandler( HistoryNewEntryEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryNewEntry"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryNewEntry( GeckoHistoryEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryEventArgs> ) Events[ HistoryNewEntryEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler<GeckoHistoryEventArgs> HistoryGoBack

		[Category( "History" )]
		public event EventHandler<GeckoHistoryEventArgs> HistoryGoBack
		{
			add { Events.AddHandler( HistoryGoBackEvent, value ); }
			remove { Events.RemoveHandler( HistoryGoBackEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryGoBack"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryGoBack( GeckoHistoryEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryEventArgs> ) Events[ HistoryGoBackEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler<GeckoHistoryEventArgs> HistoryGoForward

		[Category( "History" )]
		public event EventHandler<GeckoHistoryEventArgs> HistoryGoForward
		{
			add { Events.AddHandler( HistoryGoForwardEvent, value ); }
			remove { Events.RemoveHandler( HistoryGoForwardEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryGoForward"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryGoForward( GeckoHistoryEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryEventArgs> ) Events[ HistoryGoForwardEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler<GeckoHistoryEventArgs> HistoryReload

		[Category( "History" )]
		public event EventHandler<GeckoHistoryEventArgs> HistoryReload
		{
			add { Events.AddHandler( HistoryReloadEvent, value ); }
			remove { Events.RemoveHandler( HistoryReloadEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryReload"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryReload( GeckoHistoryEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryEventArgs> ) Events[ HistoryReloadEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoHistoryGotoIndexEventHandler HistoryGotoIndex

		[Category( "History" )]
		public event EventHandler<GeckoHistoryGotoIndexEventArgs> HistoryGotoIndex
		{
			add { Events.AddHandler( HistoryGotoIndexEvent, value ); }
			remove { Events.RemoveHandler( HistoryGotoIndexEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryGotoIndex"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryGotoIndex( GeckoHistoryGotoIndexEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryGotoIndexEventArgs> ) Events[ HistoryGotoIndexEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoHistoryPurgeEventHandler HistoryPurge

		[Category( "History" )]
		public event EventHandler<GeckoHistoryPurgeEventArgs> HistoryPurge
		{
			add { Events.AddHandler( HistoryPurgeEvent, value ); }
			remove { Events.RemoveHandler( HistoryPurgeEvent, value ); }
		}

		/// <summary>Raises the <see cref="HistoryPurge"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnHistoryPurge( GeckoHistoryPurgeEventArgs e )
		{
			var evnt = ( EventHandler<GeckoHistoryPurgeEventArgs> ) Events[ HistoryPurgeEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#endregion

		#region public event GeckoProgressEventHandler ProgressChanged

		/// <summary>
		/// Occurs when the control has updated progress information.
		/// </summary>
		[Category( "Navigation" )]
		[Description( "Occurs when the control has updated progress information." )]
		public event EventHandler<GeckoProgressEventArgs> ProgressChanged
		{
			add { Events.AddHandler( ProgressChangedEvent, value ); }
			remove { Events.RemoveHandler( ProgressChangedEvent, value ); }
		}


		/// <summary>Raises the <see cref="ProgressChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnProgressChanged( GeckoProgressEventArgs e )
		{
			var evnt = ( EventHandler<GeckoProgressEventArgs> ) Events[ ProgressChangedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region Window events

		#region public event GeckoCreateWindowEventHandler CreateWindow

		public event EventHandler<GeckoCreateWindowEventArgs> CreateWindow
		{
			add { Events.AddHandler( CreateWindowEvent, value ); }
			remove { Events.RemoveHandler( CreateWindowEvent, value ); }
		}

		/// <summary>Raises the <see cref="CreateWindow"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnCreateWindow( GeckoCreateWindowEventArgs e )
		{
			var evnt = ( EventHandler<GeckoCreateWindowEventArgs> ) Events[ CreateWindowEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoCreateWindow2EventHandler CreateWindow2

		public event EventHandler<GeckoCreateWindow2EventArgs> CreateWindow2
		{
			add { Events.AddHandler( CreateWindow2Event, value ); }
			remove { Events.RemoveHandler( CreateWindow2Event, value ); }
		}

		/// <summary>Raises the <see cref="CreateWindow"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnCreateWindow2( GeckoCreateWindow2EventArgs e )
		{
			var evnt = ( EventHandler<GeckoCreateWindow2EventArgs> ) Events[ CreateWindow2Event ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoWindowSetBoundsEventHandler WindowSetBounds



		public event EventHandler<GeckoWindowSetBoundsEventArgs> WindowSetBounds
		{
			add { Events.AddHandler( WindowSetBoundsEvent, value ); }
			remove { Events.RemoveHandler( WindowSetBoundsEvent, value ); }
		}

		/// <summary>Raises the <see cref="WindowSetBounds"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnWindowSetBounds( GeckoWindowSetBoundsEventArgs e )
		{
			var evnt = (EventHandler<GeckoWindowSetBoundsEventArgs>)Events[WindowSetBoundsEvent];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#endregion

		#region public event EventHandler StatusTextChanged

		/// <summary>
		/// Occurs when the value of the <see cref="StatusText"/> property is changed.
		/// </summary>
		[Category( "Property Changed" )]
		[Description( "Occurs when the value of the StatusText property is changed." )]
		public event EventHandler StatusTextChanged
		{
			add { Events.AddHandler( StatusTextChangedEvent, value ); }
			remove { Events.RemoveHandler( StatusTextChangedEvent, value ); }
		}

		/// <summary>Raises the <see cref="StatusTextChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnStatusTextChanged( EventArgs e )
		{
			var evnt = ( EventHandler ) Events[ StatusTextChangedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event EventHandler DocumentTitleChanged

		/// <summary>
		/// Occurs when the value of the <see cref="DocumentTitle"/> property is changed.
		/// </summary>
		[Category( "Property Changed" )]
		[Description( "Occurs when the value of the DocumentTitle property is changed." )]
		public event EventHandler DocumentTitleChanged
		{
			add { Events.AddHandler( DocumentTitleChangedEvent, value ); }
			remove { Events.RemoveHandler( DocumentTitleChangedEvent, value ); }
		}

		/// <summary>Raises the <see cref="DocumentTitleChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDocumentTitleChanged( EventArgs e )
		{
			var evnt = ( EventHandler ) Events[ DocumentTitleChangedEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoContextMenuEventHandler ShowContextMenu

		public event EventHandler<GeckoContextMenuEventArgs> ShowContextMenu
		{
			add { Events.AddHandler( ShowContextMenuEvent, value ); }
			remove { Events.RemoveHandler( ShowContextMenuEvent, value ); }
		}

		/// <summary>Raises the <see cref="ShowContextMenu"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnShowContextMenu( GeckoContextMenuEventArgs e )
		{
			var evnt = ( EventHandler<GeckoContextMenuEventArgs> ) Events[ ShowContextMenuEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region public event GeckoObserveHttpModifyRequestEventHandler Navigated

		/// <summary>
		/// Occurs after the browser has send a http request to the web
		/// </summary>
		[Category( "Observe" )]
		[Description( "Occurs after the browser has navigated to a new page." )]
		public event EventHandler<GeckoObserveHttpModifyRequestEventArgs> ObserveHttpModifyRequest
		{
			add { Events.AddHandler( ObserveHttpModifyRequestEvent, value ); }
			remove { Events.RemoveHandler( ObserveHttpModifyRequestEvent, value ); }
		}

		/// <summary>Raises the <see cref="ObserveHttpModify"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnObserveHttpModifyRequest(GeckoObserveHttpModifyRequestEventArgs e)
		{
			var evnt = ( EventHandler<GeckoObserveHttpModifyRequestEventArgs> ) Events[ ObserveHttpModifyRequestEvent ];
			if ( evnt != null ) evnt( this, e );
		}

		#endregion

		#region Dom EventHandlers

		#region Dom keyboard events
		#region public event GeckoDomKeyEventHandler DomKeyDown
		[Category("DOM Events")]
		public event GeckoDomKeyEventHandler DomKeyDown
		{
			add { Events.AddHandler(DomKeyDownEvent, value); }
			remove { Events.RemoveHandler(DomKeyDownEvent, value); }
		}

		/// <summary>Raises the <see cref="DomKeyDown"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomKeyDown(GeckoDomKeyEventArgs e)
		{
			var evnt = (GeckoDomKeyEventHandler)Events[DomKeyDownEvent];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomKeyEventHandler DomKeyUp
		[Category("DOM Events")]
		public event GeckoDomKeyEventHandler DomKeyUp
		{
			add { Events.AddHandler(DomKeyUpEvent, value); }
			remove { Events.RemoveHandler(DomKeyUpEvent, value); }
		}

		/// <summary>Raises the <see cref="DomKeyUp"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomKeyUp(GeckoDomKeyEventArgs e)
		{
			var evnt = (GeckoDomKeyEventHandler)Events[DomKeyUpEvent];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomKeyEventHandler DomKeyPress
		[Category("DOM Events")]
		public event GeckoDomKeyEventHandler DomKeyPress
		{
			add { Events.AddHandler(DomKeyPressEvent, value); }
			remove { Events.RemoveHandler(DomKeyPressEvent, value); }
		}

		/// <summary>Raises the <see cref="DomKeyPress"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomKeyPress(GeckoDomKeyEventArgs e)
		{
			var evnt = ( GeckoDomKeyEventHandler ) Events[ DomKeyPressEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion
		#endregion

		#region Dom mouse events
		#region public event GeckoDomMouseEventHandler DomMouseDown
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseDown
		{
			add { Events.AddHandler(DomMouseDownEvent, value); }
			remove { Events.RemoveHandler(DomMouseDownEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomMouseDown"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseDown(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomMouseDownEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DomMouseUp
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseUp
		{
			add { Events.AddHandler(DomMouseUpEvent, value); }
			remove { Events.RemoveHandler(DomMouseUpEvent, value); }
		}

		/// <summary>Raises the <see cref="DomMouseUp"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseUp(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomMouseUpEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DomMouseOver
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseOver
		{
			add { Events.AddHandler(DomMouseOverEvent, value); }
			remove { Events.RemoveHandler(DomMouseOverEvent, value); }
		}
		

		/// <summary>Raises the <see cref="DomMouseOver"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseOver(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) this.Events[ DomMouseOverEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DomMouseOut
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseOut
		{
			add { Events.AddHandler(DomMouseOutEvent, value); }
			remove { Events.RemoveHandler(DomMouseOutEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomMouseOut"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseOut(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomMouseOutEvent ];
			if (evnt != null) evnt( this, e );
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DomMouseMove
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseMove
		{
			add { Events.AddHandler(DomMouseMoveEvent, value); }
			remove { Events.RemoveHandler(DomMouseMoveEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomMouseMove"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseMove(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomMouseMoveEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DomContextMenu
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomContextMenu
		{
			add { Events.AddHandler(DomContextMenuEvent, value); }
			remove { Events.RemoveHandler(DomContextMenuEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomContextMenu"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomContextMenu(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomContextMenuEvent ];
			if (evnt != null)evnt(this, e);
		}
		#endregion

		#region public event GeckoDomMouseEventHandler DOMMouseScroll
		[Category("DOM Events")]
		public event GeckoDomMouseEventHandler DomMouseScroll
		{
			add { Events.AddHandler(DomMouseScrollEvent, value); }
			remove { Events.RemoveHandler(DomMouseScrollEvent, value); }
		}

		/// <summary>Raises the <see cref="DomMouseScroll"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomMouseScroll(GeckoDomMouseEventArgs e)
		{
			var evnt = ( GeckoDomMouseEventHandler ) Events[ DomMouseScrollEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion
		#endregion

		#region public event GeckoDomEventHandler DomSubmit
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomSubmit
		{
			add { Events.AddHandler(DomSubmitEvent, value); }
			remove { Events.RemoveHandler(DomSubmitEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomSubmit"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomSubmit(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomSubmitEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomCompositionStart
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomCompositionStart
		{
			add { Events.AddHandler(DomCompositionStartEvent, value); }
			remove { Events.RemoveHandler(DomCompositionStartEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomCompositionStart"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomCompositionStart(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomCompositionStartEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomCompositionEnd
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomCompositionEnd
		{
			add { Events.AddHandler(DomCompositionEndEvent, value); }
			remove { Events.RemoveHandler(DomCompositionEndEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomCompositionEnd"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomCompositionEnd(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomCompositionEndEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomFocus
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomFocus
		{
			add { Events.AddHandler(DomFocusEvent, value); }
			remove { Events.RemoveHandler(DomFocusEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomFocus"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomFocus(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomFocusEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomBlur
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomBlur
		{
			add { Events.AddHandler(DomBlurEvent, value); }
			remove { Events.RemoveHandler(DomBlurEvent, value); }
		}

		/// <summary>Raises the <see cref="DomBlur"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomBlur(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomBlurEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler Load
		[Category("DOM Events")]
		public event GeckoDomEventHandler Load
		{
			add { Events.AddHandler(LoadEvent, value); }
			remove { Events.RemoveHandler(LoadEvent, value); }
		}
		
		/// <summary>Raises the <see cref="LoadEvent"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnLoad(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ LoadEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomContentChanged
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomContentChanged
		{
			add { Events.AddHandler(DomContentChangedEvent, value); }
			remove { Events.RemoveHandler(DomContentChangedEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomContentChangedEvent"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomContentChanged(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomContentChangedEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomClick
		[Category("DOM Events")]
		public event GeckoDomEventHandler DomClick
		{
			add { Events.AddHandler(DomClickEvent, value); }
			remove { Events.RemoveHandler(DomClickEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomClick"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomClick(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomClickEvent ];
			if (evnt != null) evnt(this, e);
		}
		#endregion

		#region public event GeckoDomEventHandler DomDoubleClick

		[Category("DOM Events")]
		public event GeckoDomEventHandler DomDoubleClick
		{
			add { Events.AddHandler(DomDoubleClickEvent, value); }
			remove { Events.RemoveHandler(DomDoubleClickEvent, value); }
		}
		
		/// <summary>Raises the <see cref="DomDoubleClick"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnDomDoubleClick(GeckoDomEventArgs e)
		{
			var evnt = ( GeckoDomEventHandler ) Events[ DomDoubleClickEvent ];
			if (evnt != null) evnt(this, e);
		}

		#endregion public event GeckoDomEventHandler DomDoubleClick

		#endregion

		#region event JavascriptErrorEventHandler JavascriptError

		internal class JSErrorHandler : jsdIErrorHook
		{
			GeckoWebBrowser m_browser;

			internal JSErrorHandler(GeckoWebBrowser browser)
			{
				m_browser = browser;
			}

			public bool OnError(nsAUTF8StringBase message, nsAUTF8StringBase fileName, uint line, uint pos, uint flags, uint errnum, jsdIValue exc)
			{
				var eventArgs = new JavascriptErrorEventArgs(message.ToString(), fileName.ToString(), line, pos, flags, errnum);
				m_browser.OnJavascriptError(eventArgs);
				return true;
			}
		}

		public void EnableJavascriptDebugger()
		{
			if (m_javascriptDebuggingEnabled)
				return;

			using (var a = new AutoJSContext())
			{
				var jsd = Xpcom.GetService<jsdIDebuggerService>("@mozilla.org/js/jsd/debugger-service;1");
				jsd.SetErrorHookAttribute(new JSErrorHandler(this));
				nsIJSRuntimeService runtime = Xpcom.GetService<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1");
				jsd.ActivateDebugger(runtime.GetRuntimeAttribute());
				Marshal.ReleaseComObject(runtime);
				Marshal.ReleaseComObject(jsd);
			}

			m_javascriptDebuggingEnabled = true;
		}

		public delegate void JavascriptErrorEventHandler(object sender, JavascriptErrorEventArgs e);

		private JavascriptErrorEventHandler _JavascriptError;

		public event JavascriptErrorEventHandler JavascriptError
		{
			add
			{
				EnableJavascriptDebugger();
				_JavascriptError += value;
			}
			remove { _JavascriptError -= value; }
		}

		protected virtual void OnJavascriptError(JavascriptErrorEventArgs e)
		{
			if (_JavascriptError != null)
				_JavascriptError(this, e);
		}

		#endregion

		#region event EventHandler<ConsoleMessageEventArgs> ConsoleMessage

		public sealed class ConsoleListener
			: nsIConsoleListener
		{
			GeckoWebBrowser m_browser;

			public ConsoleListener(GeckoWebBrowser browser)
			{
				m_browser = browser;
			}

			public void Observe(nsIConsoleMessage aMessage)
			{
				var e = new ConsoleMessageEventArgs(aMessage.GetMessageAttribute());
				m_browser.OnConsoleMessage(e);
			}
		}

		public void EnableConsoleMessageNotfication()
		{
			using (var consoleService = new ConsoleService())
			{
				consoleService._nativeService.RegisterListener(new ConsoleListener(this));
			}
		}

		private EventHandler<ConsoleMessageEventArgs> _ConsoleMessage;

		public event EventHandler<ConsoleMessageEventArgs> ConsoleMessage
		{
			add
			{
				EnableConsoleMessageNotfication();
				_ConsoleMessage += value;
			}
			remove { _ConsoleMessage -= value; }
		}


		protected virtual void OnConsoleMessage(ConsoleMessageEventArgs e)
		{
			if (_ConsoleMessage != null)
				_ConsoleMessage(this, e);
		}

		#endregion
	}

	#region EventArgs Classes

	#region GeckoHistoryEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoHistoryEventArgs
		: CancelEventArgs
	{
		/// <summary>
		/// Gets the URL of the history entry.
		/// </summary>
		public readonly Uri Url;

		/// <summary>Creates a new instance of a <see cref="GeckoHistoryEventArgs"/> object.</summary>
		/// <param name="url"></param>
		public GeckoHistoryEventArgs(Uri url)
		{
			Url = url;
		}
	}
	#endregion

	#region GeckoHistoryGotoIndexEventArgs

	/// <summary>Provides data for event.</summary>
	public class GeckoHistoryGotoIndexEventArgs
		: GeckoHistoryEventArgs
	{
		/// <summary>
		/// Gets the index in history of the document to be loaded.
		/// </summary>
		public readonly int Index;

		/// <summary>Creates a new instance of a <see cref="GeckoHistoryGotoIndexEventArgs"/> object.</summary>
		/// <param name="url"></param>
		/// <param name="index"></param>
		public GeckoHistoryGotoIndexEventArgs(Uri url, int index)
			: base(url)
		{
			Index = index;
		}
	}
	#endregion

	#region GeckoHistoryPurgeEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoHistoryPurgeEventArgs
		: CancelEventArgs
	{
		/// <summary>
		/// Gets the number of entries to be purged from the history.
		/// </summary>
		public readonly int Count;

		/// <summary>Creates a new instance of a <see cref="GeckoHistoryPurgeEventArgs"/> object.</summary>
		/// <param name="count"></param>
		public GeckoHistoryPurgeEventArgs(int count)
		{
			Count = count;
		}

	}
	#endregion

	#region GeckoProgressEventArgs
	/// <summary>Provides data for  event.</summary>
	public class GeckoProgressEventArgs
		: EventArgs
	{
		public readonly int CurrentProgress;
		public readonly int MaximumProgress;
		/// <summary>Creates a new instance of a <see cref="GeckoProgressEventArgs"/> object.</summary>
		public GeckoProgressEventArgs(int current, int max)
		{
			CurrentProgress = current;
			MaximumProgress = max;
		}
	}
	#endregion

	#region GeckoNavigatedEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoNavigatedEventArgs
		: EventArgs
	{
		// Wrapper is not often needed, so store only nsIRequest
		private nsIRequest _responce;
		private GeckoResponse _wrapper;

		public readonly Uri Uri;

		/// <summary>Creates a new instance of a <see cref="GeckoNavigatedEventArgs"/> object.</summary>
		/// <param name="value"></param>
		/// <param name="response"></param>
		internal GeckoNavigatedEventArgs(Uri value, nsIRequest response)
		{
			Uri = value;
			_responce = response;
		}

		public GeckoResponse Response
		{
			get { return _wrapper ?? ( _wrapper = new GeckoResponse( _responce ) ); }
		}

	}
	#endregion

	#region GeckoNavigatingEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoNavigatingEventArgs
		: CancelEventArgs
	{
		public readonly Uri Uri;

		/// <summary>Creates a new instance of a <see cref="GeckoNavigatingEventArgs"/> object.</summary>
		/// <param name="value"></param>
		public GeckoNavigatingEventArgs(Uri value)
		{
			Uri = value;
		}
	}
	#endregion

	#region GeckoCreateWindowEventArgs

	/// <summary>Provides data for event.</summary>
	public class GeckoCreateWindowEventArgs
		: EventArgs
	{
		private GeckoWebBrowser _webBrowser;

		public readonly GeckoWindowFlags Flags;
		
		/// <summary>Creates a new instance of a <see cref="GeckoCreateWindowEventArgs"/> object.</summary>
		/// <param name="flags"></param>
		public GeckoCreateWindowEventArgs(GeckoWindowFlags flags)
		{
			Flags = flags;
		}

		/// <summary>
		/// Gets or sets the <see cref="GeckoWebBrowser"/> used in the new window.
		/// </summary>
		public GeckoWebBrowser WebBrowser
		{
			get { return _webBrowser; }
			set { _webBrowser = value; }
		}
		
	}
	#endregion

	#region GeckoCreateWindow2EventArgs

	/// <summary>Provides data for event.</summary>
	public class GeckoCreateWindow2EventArgs
		: CancelEventArgs
	{
		private GeckoWebBrowser _webBrowser;

		public readonly String Uri;
		public readonly GeckoWindowFlags Flags;

		/// <summary>Creates a new instance of a <see cref="GeckoCreateWindowEventArgs"/> object.</summary>
		/// <param name="flags"></param>
		/// <param name="uri"></param>
		public GeckoCreateWindow2EventArgs(GeckoWindowFlags flags, String uri)
			:base(false)
		{
			Flags = flags;
			Uri = uri;
		}

		/// <summary>
		/// Gets or sets the <see cref="GeckoWebBrowser"/> used in the new window.
		/// </summary>
		public GeckoWebBrowser WebBrowser
		{
			get { return _webBrowser; }
			set { _webBrowser = value; }
		}
	}
	#endregion

	#region GeckoWindowSetBoundsEventArgs

	/// <summary>Provides data for event.</summary>
	public class GeckoWindowSetBoundsEventArgs
		: EventArgs
	{
		public readonly Rectangle Bounds;
		public readonly BoundsSpecified BoundsSpecified;

		/// <summary>Creates a new instance of a <see cref="GeckoWindowSetBoundsEventArgs"/> object.</summary>
		/// <param name="bounds"></param>
		/// <param name="specified"></param>
		public GeckoWindowSetBoundsEventArgs(Rectangle bounds, BoundsSpecified specified)
		{
			Bounds = bounds;
			BoundsSpecified = specified;
		}
	}
	#endregion

	#region GeckoContextMenuEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoContextMenuEventArgs
		: EventArgs
	{
		/// <summary>
		/// Gets the location where the context menu will be displayed.
		/// </summary>
		public readonly Point Location;
		public readonly Uri BackgroundImageSrc;
		public readonly Uri ImageSrc;
		public readonly string AssociatedLink;

		private GeckoNode _targetNode;

		/// <summary>Creates a new instance of a <see cref="GeckoContextMenuEventArgs"/> object.</summary>
		public GeckoContextMenuEventArgs(Point location, ContextMenu contextMenu, string associatedLink, Uri backgroundImageSrc, Uri imageSrc, GeckoNode targetNode)
		{
			Location = location;
			_contextMenu = contextMenu;
			AssociatedLink = associatedLink;
			BackgroundImageSrc = backgroundImageSrc;
			ImageSrc = imageSrc;
			_targetNode = targetNode;
		}

		

		/// <summary>
		/// Gets or sets the context menu to be displayed.  Set this property to null to disable
		/// the context menu.
		/// </summary>
		public ContextMenu ContextMenu
		{
			get { return _contextMenu; }
			set { _contextMenu = value; }
		}
		ContextMenu _contextMenu;

		

		public GeckoNode TargetNode
		{
			get { return _targetNode; }
		}
		
	}
	#endregion

	#region GeckoObserveHttpModifyRequestEventArgs
	/// <summary>Provides data for event.</summary>
	public class GeckoObserveHttpModifyRequestEventArgs
		: CancelEventArgs
	{
		public readonly Uri Uri;
		public readonly Uri Referrer;
		public readonly string RequestMethod;
		public readonly string RequestData;

		/// <summary>Creates a new instance of a <see cref="GeckoObserveHttpModifyRequestEventArgs"/> object.</summary>
		/// <param name="value"></param>
		/// <param name="refVal"></param>
		/// <param name="reqMethod"></param>
		/// <param name="reqData"></param>
		public GeckoObserveHttpModifyRequestEventArgs(Uri value, Uri refVal, String reqMethod, String reqData)
			:base(false)
		{
			Uri = value;
			Referrer = refVal;
			RequestMethod = reqMethod;
			RequestData = reqData;
		}
	}
	#endregion

	#endregion
}
