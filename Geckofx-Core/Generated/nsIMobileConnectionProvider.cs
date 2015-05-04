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
// Generated by IDLImporter from file nsIMobileConnectionProvider.idl
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
	[Guid("c6d98e6a-d96f-45fe-aa86-01453a6daf9e")]
	public interface nsIMobileConnectionListener
	{
		
		/// <summary>
        /// Notify when voice info is changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyVoiceChanged();
		
		/// <summary>
        /// Notify when data info is changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDataChanged();
		
		/// <summary>
        /// Notify when ussd is received.
        ///
        /// @param message
        /// The ussd request in string format.
        /// @param sessionEnded
        /// Indicates whether the session is ended.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyUssdReceived([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.U1)] bool sessionEnded);
		
		/// <summary>
        /// Notify when data call is failed to establish.
        ///
        /// @param message
        /// Error message from RIL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDataError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message);
		
		/// <summary>
        /// Notify when call forwarding state is changed.
        ///
        /// @param success
        /// Indicates whether the set call forwarding request is success.
        /// @param action
        /// One of the nsIMobileConnectionProvider.CALL_FORWARD_ACTION_* values.
        /// @param reason
        /// One of the nsIMobileConnectionProvider.CALL_FORWARD_REASON_* values.
        /// @param number
        /// Phone number of forwarding address.
        /// @param timeSeconds
        /// The time in seconds should wait before call is forwarded.
        /// @param serviceClass
        /// One of the nsIMobileConnectionProvider.ICC_SERVICE_CLASS_* values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCFStateChange([MarshalAs(UnmanagedType.U1)] bool success, ushort action, ushort reason, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort timeSeconds, ushort serviceClass);
		
		/// <summary>
        /// Notify when emergency callback mode is changed.
        ///
        /// @param active
        /// Indicates whether the emergency callback mode is activated.
        /// @param timeoutMs
        /// The timeout in millisecond for emergency callback mode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyEmergencyCbModeChanged([MarshalAs(UnmanagedType.U1)] bool active, uint timeoutMs);
		
		/// <summary>
        /// Notify when ota status is changed.
        ///
        /// @param status
        /// Ota status. Possible values: 'spl_unlocked', 'spc_retries_exceeded',
        /// 'a_key_exchanged', 'ssd_updated', 'nam_downloaded', 'mdn_downloaded',
        /// 'imsi_downloaded', 'prl_downloaded', 'committed', 'otapa_started',
        /// 'otapa_stopped', 'otapa_aborted'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyOtaStatusChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase status);
		
		/// <summary>
        /// Notify when icc id is changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyIccChanged();
		
		/// <summary>
        /// Notify when radio state is changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyRadioStateChanged();
		
		/// <summary>
        /// Notify when clir mode is changed.
        ///
        /// @param mode
        /// One of the nsIMobileConnectionProvider.CLIR_* values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyClirModeChanged(uint mode);
	}
	
	/// <summary>
    /// XPCOM component (in the content process) that provides the mobile
    /// network information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2a3af80f-9f8e-447d-becd-034f95e4cd4d")]
	public interface nsIMobileConnectionProvider
	{
		
		/// <summary>
        /// Called when a content process registers receiving unsolicited messages from
        /// RadioInterfaceLayer in the chrome process. Only a content process that has
        /// the 'mobileconnection' permission is allowed to register.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterMobileConnectionMsg(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIMobileConnectionListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterMobileConnectionMsg(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIMobileConnectionListener listener);
		
		/// <summary>
        /// These two fields require the 'mobilenetwork' permission.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastKnownNetwork(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastKnownHomeNetwork(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the connection information about the voice.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return a nsIMobileConnectionInfo
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMobileConnectionInfo GetVoiceConnectionInfo(uint clientId);
		
		/// <summary>
        /// Get the connection information about the data.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return a nsIMobileConnectionInfo
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMobileConnectionInfo GetDataConnectionInfo(uint clientId);
		
		/// <summary>
        /// Get the integrated circuit card identifier of the SIM.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return a DOMString indicates the iccId
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIccId(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the selection mode of the voice and data networks.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return a DOMString
        /// Possible values: 'automatic', 'manual', null (unknown).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetworkSelectionMode(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the current radio state.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return a DOMString
        /// Possible values: 'enabling', 'enabled', 'disabling', 'disabled',
        /// null (unknown).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRadioState(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the network types that are supported by this radio.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        ///
        /// @return an array of DOMString
        /// Possible values: 'gsm', 'wcdma', 'cdma', 'evdo', 'lte'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetSupportedNetworkTypes(uint clientId);
		
		/// <summary>
        /// Search for available networks.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be an array of nsIMobileNetworkInfo.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetNetworks(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Manually selects the passed in network, overriding the radio's current
        /// selection.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param network
        /// The manually selecting network.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SelectNetwork(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsIMobileNetworkInfo network);
		
		/// <summary>
        /// Tell the radio to automatically select a network.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SelectNetworkAutomatically(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Set preferred network type.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param type
        /// DOMString indicates the desired preferred network type.
        /// Possible values: 'wcdma/gsm', 'gsm', 'wcdma', 'wcdma/gsm-auto',
        /// 'cdma/evdo', 'cdma', 'evdo', 'wcdma/gsm/cdma/evdo',
        /// 'lte/cdma/evdo', 'lte/wcdma/gsm', 'lte/wcdma/gsm/cdma/evdo' or
        /// 'lte'.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetPreferredNetworkType(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type);
		
		/// <summary>
        /// Query current preferred network type.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be a string indicating the current preferred network type.
        /// The value will be either 'wcdma/gsm', 'gsm', 'wcdma', 'wcdma/gsm-auto',
        /// 'cdma/evdo', 'cdma', 'evdo', 'wcdma/gsm/cdma/evdo', 'lte/cdma/evdo',
        /// 'lte/wcdma/gsm', 'lte/wcdma/gsm/cdma/evdo' or 'lte'.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetPreferredNetworkType(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Set roaming preference.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param mode
        /// DOMString indicates the desired roaming preference.
        /// Possible values: 'home', 'affiliated', or 'any'.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetRoamingPreference(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mode);
		
		/// <summary>
        /// Query current roaming preference.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be a string indicating the current roaming preference.
        /// The value will be either 'home', 'affiliated', or 'any'.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetRoamingPreference(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Set voice privacy preference.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param enabled
        /// Boolean indicates the preferred voice privacy mode used in voice
        /// scrambling in CDMA networks. 'True' means the enhanced voice security
        /// is required.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetVoicePrivacyMode(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.U1)] bool enabled);
		
		/// <summary>
        /// Query current voice privacy mode.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be a boolean indicating the current voice privacy mode.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetVoicePrivacyMode(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Send a MMI message.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param mmi
        /// DOMString containing an MMI string that can be associated to a
        /// USSD request or other RIL functionality.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be an object containing information about the operation.
        /// @see MozMMIResult for the detail of result.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be a DOMMMIError.
        /// @see DOMMMIError for the detail of error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SendMMI(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mmi);
		
		/// <summary>
        /// Cancel the current MMI request if one exists.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be an object containing information about the operation.
        /// @see MozMMIResult for the detail of result.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be a DOMMMIError.
        /// @see DOMMMIError for the detail of error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest CancelMMI(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Queries current call forwarding options.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param reason
        /// Indicates the reason the call is being forwarded. It shall be one of
        /// the nsIMobileConnectionProvider.CALL_FORWARD_REASON_* values.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be an array of MozCallForwardingOptions.
        /// @see MozCallForwardingOptions for the detail of result.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetCallForwarding(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ushort reason);
		
		/// <summary>
        /// Configures call forwarding options.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param options
        /// An object containing the call forward rule to set.
        /// @see MozCallForwardingOptions for the detail of options.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetCallForwarding(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ref Gecko.JsVal options);
		
		/// <summary>
        /// Queries current call barring status.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param options
        /// An object containing the call barring rule to query. No need to
        /// specify 'enabled' property.
        /// @see MozCallBarringOptions for the detail of options.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be an object of MozCallBarringOptions with correct 'enabled'
        /// property indicating the status of this rule.
        /// @see MozCallBarringOptions for the detail of result.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetCallBarring(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ref Gecko.JsVal options);
		
		/// <summary>
        /// Configures call barring option.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param options
        /// An object containing the call barring rule to set.
        /// @see MozCallBarringOptions for the detail of options.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetCallBarring(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ref Gecko.JsVal options);
		
		/// <summary>
        /// Change call barring facility password.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param options
        /// An object containing information about pin and newPin, and,
        /// this object must have both "pin" and "newPin" attributes
        /// to change the call barring facility password.
        /// @see MozCallBarringOptions for the detail of options.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ChangeCallBarringPassword(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ref Gecko.JsVal options);
		
		/// <summary>
        /// Configures call waiting options.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param enabled
        /// Boolean indicates the desired call waiting status.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetCallWaiting(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.U1)] bool enabled);
		
		/// <summary>
        /// Queries current call waiting options.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be a boolean indicating the call waiting status.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetCallWaiting(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Enables or disables the presentation of the calling line identity (CLI) to
        /// the called party when originating a call.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param clirMode
        /// One of the nsIMobileConnectionProvider.CLIR_* values.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'InvalidParameter', 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetCallingLineIdRestriction(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ushort clirMode);
		
		/// <summary>
        /// Queries current CLIR status.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called. And the request's
        /// result will be a an object containing CLIR 'n' and 'm' parameter.
        /// @see MozClirStatus for the detail of result.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetCallingLineIdRestriction(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Exit emergency callback mode.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'RadioNotAvailable', 'RequestNotSupported',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ExitEmergencyCbMode(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Set radio enabled/disabled.
        ///
        /// @param clientId
        /// Indicate the RIL client, 0 ~ (number of client - 1).
        /// @param window
        /// Current window.
        /// @param enabled
        /// Boolean indicates the desired radio power. True to enable the radio.
        ///
        /// @return a nsIDOMDOMRequest
        ///
        /// If successful, the request's onsuccess will be called.
        ///
        /// Otherwise, the request's onerror will be called, and the request's error
        /// will be either 'InvalidStateError', 'RadioNotAvailable',
        /// 'IllegalSIMorME', or 'GenericFailure'.
        ///
        /// Note: Request is not available when radioState is null, 'enabling', or
        /// 'disabling'. Calling the function in above conditions will receive
        /// 'InvalidStateError' error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetRadioEnabled(uint clientId, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.U1)] bool enabled);
	}
	
	/// <summary>nsIMobileConnectionProviderConsts </summary>
	public class nsIMobileConnectionProviderConsts
	{
		
		// <summary>
        // XPCOM component (in the content process) that provides the mobile
        // network information.
        // </summary>
		public const long ICC_SERVICE_CLASS_VOICE = (1<<0);
		
		// 
		public const long ICC_SERVICE_CLASS_DATA = (1<<1);
		
		// 
		public const long ICC_SERVICE_CLASS_FAX = (1<<2);
		
		// 
		public const long ICC_SERVICE_CLASS_SMS = (1<<3);
		
		// 
		public const long ICC_SERVICE_CLASS_DATA_SYNC = (1<<4);
		
		// 
		public const long ICC_SERVICE_CLASS_DATA_ASYNC = (1<<5);
		
		// 
		public const long ICC_SERVICE_CLASS_PACKET = (1<<6);
		
		// 
		public const long ICC_SERVICE_CLASS_PAD = (1<<7);
		
		// 
		public const long ICC_SERVICE_CLASS_MAX = (1<<7);
		
		// <summary>
        // Call forwarding action.
        //
        // @see 3GPP TS 27.007 7.11 "mode".
        // </summary>
		public const long CALL_FORWARD_ACTION_DISABLE = 0;
		
		// 
		public const long CALL_FORWARD_ACTION_ENABLE = 1;
		
		// 
		public const long CALL_FORWARD_ACTION_QUERY_STATUS = 2;
		
		// 
		public const long CALL_FORWARD_ACTION_REGISTRATION = 3;
		
		// 
		public const long CALL_FORWARD_ACTION_ERASURE = 4;
		
		// <summary>
        // Call forwarding reason.
        //
        // @see 3GPP TS 27.007 7.11 "reason".
        // </summary>
		public const long CALL_FORWARD_REASON_UNCONDITIONAL = 0;
		
		// 
		public const long CALL_FORWARD_REASON_MOBILE_BUSY = 1;
		
		// 
		public const long CALL_FORWARD_REASON_NO_REPLY = 2;
		
		// 
		public const long CALL_FORWARD_REASON_NOT_REACHABLE = 3;
		
		// 
		public const long CALL_FORWARD_REASON_ALL_CALL_FORWARDING = 4;
		
		// 
		public const long CALL_FORWARD_REASON_ALL_CONDITIONAL_CALL_FORWARDING = 5;
		
		// <summary>
        // Call barring program.
        // </summary>
		public const long CALL_BARRING_PROGRAM_ALL_OUTGOING = 0;
		
		// 
		public const long CALL_BARRING_PROGRAM_OUTGOING_INTERNATIONAL = 1;
		
		// 
		public const long CALL_BARRING_PROGRAM_OUTGOING_INTERNATIONAL_EXCEPT_HOME = 2;
		
		// 
		public const long CALL_BARRING_PROGRAM_ALL_INCOMING = 3;
		
		// 
		public const long CALL_BARRING_PROGRAM_INCOMING_ROAMING = 4;
		
		// <summary>
        // Calling line identification restriction constants.
        //
        // @see 3GPP TS 27.007 7.7 Defined values.
        // </summary>
		public const long CLIR_DEFAULT = 0;
		
		// 
		public const long CLIR_INVOCATION = 1;
		
		// 
		public const long CLIR_SUPPRESSION = 2;
	}
}
