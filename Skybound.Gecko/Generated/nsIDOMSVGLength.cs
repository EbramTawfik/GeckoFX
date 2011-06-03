// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGLength.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGLength.idl
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
	
	
	/// <summary>nsIDOMSVGLength </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2596325c-aed0-487e-96a1-0a6d589b9c6b")]
	public interface nsIDOMSVGLength
	{
		
		/// <summary>Member GetUnitTypeAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetUnitTypeAttribute();
		
		/// <summary>Member GetValueAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetValueAttribute();
		
		/// <summary>Member SetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute(double aValue);
		
		/// <summary>Member GetValueInSpecifiedUnitsAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetValueInSpecifiedUnitsAttribute();
		
		/// <summary>Member SetValueInSpecifiedUnitsAttribute </summary>
		/// <param name='aValueInSpecifiedUnits'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueInSpecifiedUnitsAttribute(double aValueInSpecifiedUnits);
		
		/// <summary>Member GetValueAsStringAttribute </summary>
		/// <param name='aValueAsString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAsStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValueAsString);
		
		/// <summary>Member SetValueAsStringAttribute </summary>
		/// <param name='aValueAsString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAsStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValueAsString);
		
		/// <summary>Member NewValueSpecifiedUnits </summary>
		/// <param name='unitType'> </param>
		/// <param name='valueInSpecifiedUnits'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewValueSpecifiedUnits(ushort unitType, double valueInSpecifiedUnits);
		
		/// <summary>Member ConvertToSpecifiedUnits </summary>
		/// <param name='unitType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertToSpecifiedUnits(ushort unitType);
	}
}
