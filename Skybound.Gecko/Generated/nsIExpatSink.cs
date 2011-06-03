// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIExpatSink.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIExpatSink.idl
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
	
	
	/// <summary>nsIExpatSink </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f61c56b5-ea5b-42b4-ad3c-17416e72e238")]
	public interface nsIExpatSink
	{
		
		/// <summary>Member HandleStartElement </summary>
		/// <param name='aName'> </param>
		/// <param name='aAtts'> </param>
		/// <param name='aAttsCount'> </param>
		/// <param name='aIndex'> </param>
		/// <param name='aLineNumber'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStartElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] string aAtts, System.UInt32  aAttsCount, System.Int32  aIndex, System.UInt32  aLineNumber);
		
		/// <summary>Member HandleEndElement </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEndElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName);
		
		/// <summary>Member HandleComment </summary>
		/// <param name='aCommentText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleComment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCommentText);
		
		/// <summary>Member HandleCDataSection </summary>
		/// <param name='aData'> </param>
		/// <param name='aLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleCDataSection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string aData, System.UInt32  aLength);
		
		/// <summary>Member HandleDoctypeDecl </summary>
		/// <param name='aSubset'> </param>
		/// <param name='aName'> </param>
		/// <param name='aSystemId'> </param>
		/// <param name='aPublicId'> </param>
		/// <param name='aCatalogData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleDoctypeDecl([MarshalAs(UnmanagedType.LPStruct)] nsAString aSubset, [MarshalAs(UnmanagedType.LPStruct)] nsAString aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPublicId, [MarshalAs(UnmanagedType.Interface)] nsISupports  aCatalogData);
		
		/// <summary>Member HandleCharacterData </summary>
		/// <param name='aData'> </param>
		/// <param name='aLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleCharacterData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string aData, System.UInt32  aLength);
		
		/// <summary>Member HandleProcessingInstruction </summary>
		/// <param name='aTarget'> </param>
		/// <param name='aData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleProcessingInstruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aData);
		
		/// <summary>Member HandleXMLDeclaration </summary>
		/// <param name='aVersion'> </param>
		/// <param name='aEncoding'> </param>
		/// <param name='aStandalone'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleXMLDeclaration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aEncoding, System.Int32  aStandalone);
		
		/// <summary>Member ReportError </summary>
		/// <param name='aErrorText'> </param>
		/// <param name='aSourceText'> </param>
		/// <param name='aError'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ReportError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aErrorText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSourceText, [MarshalAs(UnmanagedType.Interface)] nsIScriptError  aError);
	}
}
