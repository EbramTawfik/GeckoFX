// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIHttpServer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIHttpServer.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIHttpServer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("71ecfba5-15cf-457f-9642-4b33f6e9baf4")]
	public interface nsIHttpServer
	{
		
		/// <summary>Member Start </summary>
		/// <param name='port'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Start(System.Int32  port);
		
		/// <summary>Member Stop </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop([MarshalAs(UnmanagedType.Interface)] nsIHttpServerStoppedCallback  callback);
		
		/// <summary>Member RegisterFile </summary>
		/// <param name='path'> </param>
		/// <param name='file'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFile([MarshalAs(UnmanagedType.LPStr)] System.String  path, [MarshalAs(UnmanagedType.Interface)] nsILocalFile  file);
		
		/// <summary>Member RegisterPathHandler </summary>
		/// <param name='path'> </param>
		/// <param name='handler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterPathHandler([MarshalAs(UnmanagedType.LPStr)] System.String  path, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler  handler);
		
		/// <summary>Member RegisterErrorHandler </summary>
		/// <param name='code'> </param>
		/// <param name='handler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterErrorHandler(System.UInt32  code, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler  handler);
		
		/// <summary>Member RegisterDirectory </summary>
		/// <param name='path'> </param>
		/// <param name='dir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterDirectory([MarshalAs(UnmanagedType.LPStr)] System.String  path, [MarshalAs(UnmanagedType.Interface)] nsILocalFile  dir);
		
		/// <summary>Member RegisterContentType </summary>
		/// <param name='extension'> </param>
		/// <param name='type'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentType([MarshalAs(UnmanagedType.LPStr)] System.String  extension, [MarshalAs(UnmanagedType.LPStr)] System.String  type);
		
		/// <summary>Member SetIndexHandler </summary>
		/// <param name='handler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIndexHandler([MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler  handler);
		
		/// <summary>Member GetIdentityAttribute </summary>
		/// <returns>A nsIHttpServerIdentity </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIHttpServerIdentity  GetIdentityAttribute();
		
		/// <summary>Member GetState </summary>
		/// <param name='path'> </param>
		/// <param name='key'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetState([MarshalAs(UnmanagedType.LPStruct)] nsAString path, [MarshalAs(UnmanagedType.LPStruct)] nsAString key);
		
		/// <summary>Member SetState </summary>
		/// <param name='path'> </param>
		/// <param name='key'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetState([MarshalAs(UnmanagedType.LPStruct)] nsAString path, [MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member GetSharedState </summary>
		/// <param name='key'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetSharedState([MarshalAs(UnmanagedType.LPStruct)] nsAString key);
		
		/// <summary>Member SetSharedState </summary>
		/// <param name='key'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSharedState([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member GetObjectState </summary>
		/// <param name='key'> </param>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetObjectState([MarshalAs(UnmanagedType.LPStruct)] nsAString key);
		
		/// <summary>Member SetObjectState </summary>
		/// <param name='key'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObjectState([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.Interface)] nsISupports  value);
	}
	
	/// <summary>nsIHttpServerStoppedCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("925a6d33-9937-4c63-abe1-a1c56a986455")]
	public interface nsIHttpServerStoppedCallback
	{
		
		/// <summary>Member OnStopped </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopped();
	}
	
	/// <summary>nsIHttpServerIdentity </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a89de175-ae8e-4c46-91a5-0dba99bbd284")]
	public interface nsIHttpServerIdentity
	{
		
		/// <summary>Member GetPrimarySchemeAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetPrimarySchemeAttribute();
		
		/// <summary>Member GetPrimaryHostAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetPrimaryHostAttribute();
		
		/// <summary>Member GetPrimaryPortAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetPrimaryPortAttribute();
		
		/// <summary>Member Add </summary>
		/// <param name='scheme'> </param>
		/// <param name='host'> </param>
		/// <param name='port'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.LPStr)] System.String  scheme, [MarshalAs(UnmanagedType.LPStr)] System.String  host, System.Int32  port);
		
		/// <summary>Member Remove </summary>
		/// <param name='scheme'> </param>
		/// <param name='host'> </param>
		/// <param name='port'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Remove([MarshalAs(UnmanagedType.LPStr)] System.String  scheme, [MarshalAs(UnmanagedType.LPStr)] System.String  host, System.Int32  port);
		
		/// <summary>Member Has </summary>
		/// <param name='scheme'> </param>
		/// <param name='host'> </param>
		/// <param name='port'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStr)] System.String  scheme, [MarshalAs(UnmanagedType.LPStr)] System.String  host, System.Int32  port);
		
		/// <summary>Member GetScheme </summary>
		/// <param name='host'> </param>
		/// <param name='port'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetScheme([MarshalAs(UnmanagedType.LPStr)] System.String  host, System.Int32  port);
		
		/// <summary>Member SetPrimary </summary>
		/// <param name='scheme'> </param>
		/// <param name='host'> </param>
		/// <param name='port'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrimary([MarshalAs(UnmanagedType.LPStr)] System.String  scheme, [MarshalAs(UnmanagedType.LPStr)] System.String  host, System.Int32  port);
	}
	
	/// <summary>nsIHttpRequestHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2bbb4db7-d285-42b3-a3ce-142b8cc7e139")]
	public interface nsIHttpRequestHandler
	{
		
		/// <summary>Member Handle </summary>
		/// <param name='request'> </param>
		/// <param name='response'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle([MarshalAs(UnmanagedType.Interface)] nsIHttpRequest  request, [MarshalAs(UnmanagedType.Interface)] nsIHttpResponse  response);
	}
	
	/// <summary>nsIHttpRequest </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("978cf30e-ad73-42ee-8f22-fe0aaf1bf5d2")]
	public interface nsIHttpRequest
	{
		
		/// <summary>Member GetMethodAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetMethodAttribute();
		
		/// <summary>Member GetSchemeAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetSchemeAttribute();
		
		/// <summary>Member GetHostAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetHostAttribute();
		
		/// <summary>Member GetPortAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetPortAttribute();
		
		/// <summary>Member GetPathAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetPathAttribute();
		
		/// <summary>Member GetQueryStringAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetQueryStringAttribute();
		
		/// <summary>Member GetHttpVersionAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetHttpVersionAttribute();
		
		/// <summary>Member GetHeader </summary>
		/// <param name='fieldName'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeader([MarshalAs(UnmanagedType.LPStr)] System.String  fieldName);
		
		/// <summary>Member HasHeader </summary>
		/// <param name='fieldName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasHeader([MarshalAs(UnmanagedType.LPStr)] System.String  fieldName);
		
		/// <summary>Member GetHeadersAttribute </summary>
		/// <returns>A nsISimpleEnumerator </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator  GetHeadersAttribute();
		
		/// <summary>Member GetBodyInputStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetBodyInputStreamAttribute();
	}
	
	/// <summary>nsIHttpResponse </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1acd16c2-dc59-42fa-9160-4f26c43c1c21")]
	public interface nsIHttpResponse
	{
		
		/// <summary>Member SetStatusLine </summary>
		/// <param name='httpVersion'> </param>
		/// <param name='statusCode'> </param>
		/// <param name='description'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatusLine([MarshalAs(UnmanagedType.LPStr)] System.String  httpVersion, ushort statusCode, [MarshalAs(UnmanagedType.LPStr)] System.String  description);
		
		/// <summary>Member SetHeader </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		/// <param name='merge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeader([MarshalAs(UnmanagedType.LPStr)] System.String  name, [MarshalAs(UnmanagedType.LPStr)] System.String  value, System.Boolean  merge);
		
		/// <summary>Member GetBodyOutputStreamAttribute </summary>
		/// <returns>A nsIOutputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream  GetBodyOutputStreamAttribute();
		
		/// <summary>Member Write </summary>
		/// <param name='data'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Write([MarshalAs(UnmanagedType.LPStr)] System.String  data);
		
		/// <summary>Member ProcessAsync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessAsync();
		
		/// <summary>Member SeizePower </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SeizePower();
		
		/// <summary>Member Finish </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish();
	}
}
