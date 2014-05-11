// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMEventTarget.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// The nsIDOMEventTarget interface is the interface implemented by all
    /// event targets in the Document Object Model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Events/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b128448c-7b53-4769-92cb-cd6eafee676c")]
	public interface nsIDOMEventTarget
	{
		
		/// <summary>
        /// This method allows the registration of event listeners on the event target.
        /// If an EventListener is added to an EventTarget while it is processing an
        /// event, it will not be triggered by the current actions but may be
        /// triggered during a later stage of event flow, such as the bubbling phase.
        ///
        /// If multiple identical EventListeners are registered on the same
        /// EventTarget with the same parameters the duplicate instances are
        /// discarded. They do not cause the EventListener to be called twice
        /// and since they are discarded they do not need to be removed with the
        /// removeEventListener method.
        ///
        /// @param   type The event type for which the user is registering
        /// @param   listener The listener parameter takes an interface
        /// implemented by the user which contains the methods
        /// to be called when the event occurs.
        /// @param   useCapture If true, useCapture indicates that the user
        /// wishes to initiate capture. After initiating
        /// capture, all events of the specified type will be
        /// dispatched to the registered EventListener before
        /// being dispatched to any EventTargets beneath them
        /// in the tree. Events which are bubbling upward
        /// through the tree will not trigger an
        /// EventListener designated to use capture.
        /// @param   wantsUntrusted If false, the listener will not receive any
        /// untrusted events (see above), if true, the
        /// listener will receive events whether or not
        /// they're trusted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture, [MarshalAs(UnmanagedType.U1)] bool wantsUntrusted, int argc);
		
		/// <summary>
        /// addSystemEventListener() adds an event listener of aType to the system
        /// group.  Typically, core code should use system group for listening to
        /// content (i.e., non-chrome) element's events.  If core code uses
        /// nsIDOMEventTarget::AddEventListener for a content node, it means
        /// that the listener cannot listen the event when web content calls
        /// stopPropagation() of the event.
        ///
        /// @param aType            An event name you're going to handle.
        /// @param aListener        An event listener.
        /// @param aUseCapture      TRUE if you want to listen the event in capturing
        /// phase.  Otherwise, FALSE.
        /// @param aWantsUntrusted  TRUE if you want to handle untrusted events.
        /// Otherwise, FALSE.
        /// @return                 NS_OK if succeed.  Otherwise, NS_ERROR_*.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture, [MarshalAs(UnmanagedType.U1)] bool aWantsUntrusted, int argc);
		
		/// <summary>
        /// This method allows the removal of event listeners from the event
        /// target. If an EventListener is removed from an EventTarget while it
        /// is processing an event, it will not be triggered by the current actions.
        /// EventListeners can never be invoked after being removed.
        /// Calling removeEventListener with arguments which do not identify any
        /// currently registered EventListener on the EventTarget has no effect.
        ///
        /// @param   type Specifies the event type of the EventListener being
        /// removed.
        /// @param   listener The EventListener parameter indicates the
        /// EventListener to be removed.
        /// @param   useCapture Specifies whether the EventListener being
        /// removed was registered as a capturing listener or
        /// not. If a listener was registered twice, one with
        /// capture and one without, each must be removed
        /// separately. Removal of a capturing listener does
        /// not affect a non-capturing version of the same
        /// listener, and vice versa.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture);
		
		/// <summary>
        /// removeSystemEventListener() should be used if you have used
        /// addSystemEventListener().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture);
		
		/// <summary>
        /// This method allows the dispatch of events into the implementations
        /// event model. Events dispatched in this manner will have the same
        /// capturing and bubbling behavior as events dispatched directly by the
        /// implementation. The target of the event is the EventTarget on which
        /// dispatchEvent is called.
        ///
        /// @param   evt Specifies the event type, behavior, and contextual
        /// information to be used in processing the event.
        /// @return  Indicates whether any of the listeners which handled the
        /// event called preventDefault. If preventDefault was called
        /// the value is false, else the value is true.
        /// @throws  INVALID_STATE_ERR: Raised if the Event's type was
        /// not specified by initializing the event before
        /// dispatchEvent was called. Specification of the Event's
        /// type as null or an empty string will also trigger this
        /// exception.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent evt);
		
		/// <summary>
        /// Returns the nsIDOMEventTarget object which should be used as the target
        /// of DOMEvents.
        /// Usually |this| is returned, but for example global object returns
        /// the outer object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetTargetForDOMEvent();
		
		/// <summary>
        /// Returns the nsIDOMEventTarget object which should be used as the target
        /// of the event and when constructing event target chain.
        /// Usually |this| is returned, but for example global object returns
        /// the inner object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetTargetForEventTargetChain();
		
		/// <summary>
        /// Called before the capture phase of the event flow.
        /// This is used to create the event target chain and implementations
        /// should set the necessary members of nsEventChainPreVisitor.
        /// At least aVisitor.mCanHandle must be set,
        /// usually also aVisitor.mParentTarget if mCanHandle is PR_TRUE.
        /// First one tells that this object can handle the aVisitor.mEvent event and
        /// the latter one is the possible parent object for the event target chain.
        /// @see nsEventDispatcher.h for more documentation about aVisitor.
        ///
        /// @param aVisitor the visitor object which is used to create the
        /// event target chain for event dispatching.
        ///
        /// @note Only nsEventDispatcher should call this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreHandleEvent(System.IntPtr aVisitor);
		
		/// <summary>
        /// If nsEventChainPreVisitor.mWantsWillHandleEvent is set PR_TRUE,
        /// called just before possible event handlers on this object will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillHandleEvent(System.IntPtr aVisitor);
		
		/// <summary>
        /// Called after the bubble phase of the system event group.
        /// The default handling of the event should happen here.
        /// @param aVisitor the visitor object which is used during post handling.
        ///
        /// @see nsEventDispatcher.h for documentation about aVisitor.
        /// @note Only nsEventDispatcher should call this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostHandleEvent(System.IntPtr aVisitor);
		
		/// <summary>
        /// Dispatch an event.
        /// @param aEvent the event that is being dispatched.
        /// @param aDOMEvent the event that is being dispatched, use if you want to
        /// dispatch nsIDOMEvent, not only WidgetEvent.
        /// @param aPresContext the current presentation context, can be nullptr.
        /// @param aEventStatus the status returned from the function, can be nullptr.
        ///
        /// @note If both aEvent and aDOMEvent are used, aEvent must be the internal
        /// event of the aDOMEvent.
        ///
        /// If aDOMEvent is not nullptr (in which case aEvent can be nullptr) it is used
        /// for dispatching, otherwise aEvent is used.
        ///
        /// @deprecated This method is here just until all the callers outside Gecko
        /// have been converted to use nsIDOMEventTarget::dispatchEvent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchDOMEvent(System.IntPtr aEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aDOMEvent, System.IntPtr aPresContext, System.IntPtr aEventStatus);
		
		/// <summary>
        /// Get the script context in which the event handlers should be run.
        /// May return null.
        /// @note Caller *must* check the value of aRv.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetContextForEventHandlers(ref int aRv);
		
		/// <summary>
        /// If the method above returns null, but a success code, this method
        /// is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetJSContextForEventHandlers();
	}
}
