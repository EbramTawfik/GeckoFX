using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko
{
	/// <summary>
	/// Represents a response to a Gecko web request.
	/// </summary>
	public class GeckoResponse
	{
		#region Gecko Interfaces
		[Guid("c63a055a-a676-4e71-bf3c-6cfa11082018"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIChannel : nsIRequest
		{
			// nsIRequest:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void GetName([MarshalAs(UnmanagedType.LPStruct)]nsACString aName);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new bool IsPending();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new int GetStatus();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Cancel(int aStatus);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Suspend();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Resume();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new IntPtr GetLoadGroup(); // nsILoadGroup
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetLoadGroup(IntPtr aLoadGroup);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new int GetLoadFlags();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetLoadFlags(int aLoadFlags);
			
			// nsIChannel:
			
			[return: MarshalAs(UnmanagedType.Interface)] 
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIURI GetOriginalURI();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetOriginalURI([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);
			
			[return: MarshalAs(UnmanagedType.Interface)] 
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIURI GetURI();
			
			[return: MarshalAs(UnmanagedType.Interface)] 
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsISupports GetOwner();
						
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetOwner([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
			
			[return: MarshalAs(UnmanagedType.Interface)] 
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIInterfaceRequestor GetNotificationCallbacks();
						
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetNotificationCallbacks(nsIInterfaceRequestor aNotificationCallbacks);
			
			[return: MarshalAs(UnmanagedType.Interface)] 
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsISupports GetSecurityInfo();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetContentType(nsACString aContentType);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetContentType(nsACString aContentType);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetContentCharset(nsACString aContentCharset);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetContentCharset(nsACString aContentCharset);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			int GetContentLength();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetContentLength(int aContentLength);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr Open(); // nsIInputStream
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void AsyncOpen(IntPtr aListener, nsISupports aContext); // aListener=nsIStreamListener
		}
		
		[Guid("9277fe09-f0cc-4cd9-bbce-581dd94b0260"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIHttpChannel : nsIChannel
		{
			// nsIRequest:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void GetName([MarshalAs(UnmanagedType.LPStruct)]nsACString aName);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new bool IsPending();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new int GetStatus();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Cancel(int aStatus);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Suspend();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void Resume();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new IntPtr GetLoadGroup(); // nsILoadGroup
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetLoadGroup(IntPtr aLoadGroup);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new int GetLoadFlags();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetLoadFlags(int aLoadFlags);			
			
			// nsIChannel:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new nsIURI GetOriginalURI();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetOriginalURI(nsIURI aOriginalURI);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new nsIURI GetURI();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new nsISupports GetOwner();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetOwner(nsISupports aOwner);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new nsIInterfaceRequestor GetNotificationCallbacks();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetNotificationCallbacks(nsIInterfaceRequestor aNotificationCallbacks);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new nsISupports GetSecurityInfo();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void GetContentType([MarshalAs(UnmanagedType.LPStruct)]nsACString aContentType);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetContentType([MarshalAs(UnmanagedType.LPStruct)]nsACString aContentType);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void GetContentCharset([MarshalAs(UnmanagedType.LPStruct)]nsACString aContentCharset);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetContentCharset([MarshalAs(UnmanagedType.LPStruct)]nsACString aContentCharset);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new int GetContentLength();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void SetContentLength(int aContentLength);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new IntPtr Open(); // nsIInputStream
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			new void AsyncOpen(IntPtr aListener, nsISupports aContext); // aListener=nsIStreamListener

			// nsIHttpChannel:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetRequestMethod([MarshalAs(UnmanagedType.LPStruct)]nsACString aRequestMethod);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetRequestMethod([MarshalAs(UnmanagedType.LPStruct)]nsACString aRequestMethod);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIURI GetReferrer();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetReferrer(nsIURI aReferrer);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetRequestHeader([MarshalAs(UnmanagedType.LPStruct)]nsACString aHeader, [MarshalAs(UnmanagedType.LPStruct)]nsACString _retval);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)]nsACString aHeader, [MarshalAs(UnmanagedType.LPStruct)]nsACString aValue, bool aMerge);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void VisitRequestHeaders(IntPtr aVisitor); // nsIHttpHeaderVisitor
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool GetAllowPipelining();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetAllowPipelining(bool aAllowPipelining);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			uint GetRedirectionLimit();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetRedirectionLimit(uint aRedirectionLimit);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			int GetResponseStatus();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetResponseStatusText([MarshalAs(UnmanagedType.LPStruct)]nsACString aResponseStatusText);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool GetRequestSucceeded();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)]nsACString header, [MarshalAs(UnmanagedType.LPStruct)]nsACString _retval);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetResponseHeader([MarshalAs(UnmanagedType.LPStruct)]nsACString header, [MarshalAs(UnmanagedType.LPStruct)]nsACString value, bool merge);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void VisitResponseHeaders(IntPtr aVisitor); // nsIHttpHeaderVisitor
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool IsNoStoreResponse();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool IsNoCacheResponse();			
		}
		
		[Guid("0cf40717-d7c1-4a94-8c1e-d6c9734101bb"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIHttpHeaderVisitor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void VisitHeader([MarshalAs(UnmanagedType.LPStruct)]nsACString aHeader, [MarshalAs(UnmanagedType.LPStruct)]nsACString aValue);
		}
		
		#endregion
		
		internal GeckoResponse(nsIRequest request)
		{
			Channel = Xpcom.QueryInterface<nsIChannel>(request);
			HttpChannel = Xpcom.QueryInterface<nsIHttpChannel>(request);
		}
		
		nsIChannel Channel;
		nsIHttpChannel HttpChannel;
		
		/// <summary>
		/// Gets the MIME type of the channel's content if available.
		/// </summary>
		public string ContentType
		{
			get { return nsString.Get(Channel.GetContentType); }
		}
		
		/// <summary>
		/// Gets the character set of the channel's content if available and if applicable.
		/// </summary>
		public string ContentCharset
		{
			get { return nsString.Get(Channel.GetContentCharset); }
		}
		
		/// <summary>
		/// Gets the length of the data associated with the channel if available. A value of -1 indicates that the content length is unknown.
		/// </summary>
		public int ContentLength
		{
			get { return Channel.GetContentLength(); }
		}
		
		/// <summary>
		/// Gets the HTTP request method.
		/// </summary>
		public string HttpRequestMethod
		{
			get { return (HttpChannel == null) ? null : nsString.Get(HttpChannel.GetRequestMethod); }
		}
		
		/// <summary>
		/// Returns true if the HTTP response code indicates success. This value will be true even when processing a 404 response because a 404 response
		/// may include a message body that (in some cases) should be shown to the user.
		/// </summary>
		public bool HttpRequestSucceeded
		{
			get { return (HttpChannel == null) ? true : HttpChannel.GetRequestSucceeded(); }
		}
		
		/// <summary>
		/// Gets the HTTP response code (a value of 200 indicates success).
		/// </summary>
		public int HttpResponseStatus
		{
			get { return (HttpChannel == null) ? 0 :HttpChannel.GetResponseStatus(); }
		}
		
		/// <summary>
		/// Gets the HTTP response status text.
		/// </summary>
		public string HttpResponseStatusText
		{
			get { return (HttpChannel == null) ? null : nsString.Get(HttpChannel.GetResponseStatusText); }
		}
	}
}
