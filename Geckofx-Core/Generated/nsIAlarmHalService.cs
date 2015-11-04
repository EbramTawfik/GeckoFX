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
// Generated by IDLImporter from file nsIAlarmHalService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f3ed2c0-aed9-11e1-8c3d-5310bd393466")]
	public interface nsIAlarmFiredCb
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAlarmFired();
	}
	
	/// <summary>nsITimezoneChangedCb </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0ca52e84-ba8f-11e1-87e8-63235527db9e")]
	public interface nsITimezoneChangedCb
	{
		
		/// <summary>Member OnTimezoneChanged </summary>
		/// <param name='aTimezoneOffset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnTimezoneChanged(int aTimezoneOffset);
	}
	
	/// <summary>nsIAlarmHalService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("057b1ee4-f696-486d-bd55-205e21e88fab")]
	public interface nsIAlarmHalService
	{
		
		/// <summary>Member SetAlarm </summary>
		/// <param name='aSeconds'> </param>
		/// <param name='aNanoseconds'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetAlarm(int aSeconds, int aNanoseconds);
		
		/// <summary>Member SetAlarmFiredCb </summary>
		/// <param name='aAlarmFiredCb'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAlarmFiredCb([MarshalAs(UnmanagedType.Interface)] nsIAlarmFiredCb aAlarmFiredCb);
		
		/// <summary>Member SetTimezoneChangedCb </summary>
		/// <param name='aTimezoneChangedCb'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimezoneChangedCb([MarshalAs(UnmanagedType.Interface)] nsITimezoneChangedCb aTimezoneChangedCb);
	}
}
