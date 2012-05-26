#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Collections.Generic;
using System.Text;

namespace Gecko
{	
	/// <summary>
	/// Provides data about a DOM event.
	/// </summary>
	public class GeckoDomEventArgs : EventArgs
	{
		internal GeckoDomEventArgs(nsIDOMEvent ev)
		{
			_Event = ev;
		}
		
		nsIDOMEvent _Event;
		
		/// <summary>
		/// Gets or sets whether the event was handled.  Setting this property prevents the target DOM object
		/// from receiving the event (if Cancelable is true).
		/// </summary>
		public bool Handled
		{
			get { return _Handled; }
			set { _Handled = value; }
		}
		bool _Handled;
		
		public bool Bubbles
		{
			get { return _Event.GetBubblesAttribute(); }
		}
		
		public bool Cancelable
		{
			get { return _Event.GetCancelableAttribute(); }
		}
		
		public GeckoElement CurrentTarget
		{
			get { return GeckoElement.Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(_Event.GetCurrentTargetAttribute())); }
		}
		
		/// <summary>
		/// Gets the final destination of the event.
		/// </summary>
		public GeckoElement Target
		{
			get { return GeckoElement.Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(_Event.GetTargetAttribute())); }
		}

		/// <summary>
		/// If an event is cancelable, the preventDefault method is used to
		/// signify that the event is to be canceled, meaning any default action
		/// normally taken by the implementation as a result of the event will
		/// not occur. If, during any stage of event flow, the preventDefault
		/// method is called the event is canceled. Any default action associated
		/// with the event will not occur. Calling this method for a
		/// non-cancelable event has no effect. Once preventDefault has been
		/// called it will remain in effect throughout the remainder of the
		/// event's propagation. This method may be used during any stage of
		/// event flow.
		/// </summary>
		public void PreventDefault()
		{
			_Event.PreventDefault();
		}

		/// <summary>
		/// The stopPropagation method is used prevent further propagation of an
		/// event during event flow. If this method is called by any
		/// EventListener the event will cease propagating through the tree. The
		/// event will complete dispatch to all listeners on the current
		/// EventTarget before event flow stops. This method may be used during
		/// any stage of event flow.
		/// </summary>
		public void StopPropagation()
		{
			_Event.StopPropagation();
		}		
	};
	
	public class GeckoDomUIEventArgs : GeckoDomEventArgs
	{
		internal GeckoDomUIEventArgs(nsIDOMUIEvent ev) : base((nsIDOMEvent)ev)
		{
			_Event = ev;
		}
		
		nsIDOMUIEvent _Event;
		
		public int Detail
		{
			get { return _Event.GetDetailAttribute(); }
		}
	};
	
	/// <summary>
	/// Provides data about a DOM key event.
	/// </summary>
	public class GeckoDomKeyEventArgs
		: GeckoDomUIEventArgs
	{
		internal GeckoDomKeyEventArgs(nsIDOMKeyEvent ev)
			: base(ev)
		{
			_Event = ev;
		}
		
		nsIDOMKeyEvent _Event;
		
		public uint KeyChar
		{
			get { return _Event.GetCharCodeAttribute(); }
		}
		
		public uint KeyCode
		{
			get { return _Event.GetKeyCodeAttribute(); }
		}
		
		public bool AltKey
		{
			get { return _Event.GetAltKeyAttribute(); }
		}
		
		public bool CtrlKey
		{
			get { return _Event.GetCtrlKeyAttribute(); }
		}
		
		public bool ShiftKey
		{
			get { return _Event.GetShiftKeyAttribute(); }
		}
	};
	
	/// <summary>
	/// Provides data about a DOM mouse event.
	/// </summary>
	public class GeckoDomMouseEventArgs : GeckoDomUIEventArgs
	{
		internal GeckoDomMouseEventArgs(nsIDOMMouseEvent ev) : base((nsIDOMUIEvent)ev)
		{
			_Event = ev;
		}
		
		nsIDOMMouseEvent _Event;
		
		/// <summary>
		/// The X coordinate of the mouse pointer in local (DOM content) coordinates.
		/// </summary>
		public int ClientX
		{
			get { return _Event.GetClientXAttribute(); }
		}
		
		/// <summary>
		/// The Y coordinate of the mouse pointer in local (DOM content) coordinates.
		/// </summary>
		public int ClientY
		{
			get { return _Event.GetClientYAttribute(); }
		}
		
		/// <summary>
		/// The X coordinate of the mouse pointer in global (screen) coordinates.
		/// </summary>
		public int ScreenX
		{
			get { return _Event.GetScreenXAttribute(); }
		}
		
		/// <summary>
		/// The Y coordinate of the mouse pointer in global (screen) coordinates.
		/// </summary>
		public int ScreenY
		{
			get { return _Event.GetScreenYAttribute(); }
		}
		
		/// <summary>
		/// The button number that was pressed when the mouse event was fired.
		/// </summary>
		public GeckoMouseButton Button
		{
			get { return (GeckoMouseButton)_Event.GetButtonAttribute(); }
		}
		
		/// <summary>
		/// true if the alt key was down when the mouse event was fired.
		/// </summary>
		public bool AltKey
		{
			get { return _Event.GetAltKeyAttribute(); }
		}

		/// <summary>
		/// Indicates which mouse wheel axis changed; this will be either HORIZONTAL_AXIS (1) or VERTICAL_AXIS (2).
		/// </summary>
		public int Axis
		{
			get { 
				if(_Event is nsIDOMMouseScrollEvent)
					return (_Event as nsIDOMMouseScrollEvent).GetAxisAttribute();
				return -1;
			}
		}
		
		/// <summary>
		/// true if the control key was down when the mouse event was fired.
		/// </summary>
		public bool CtrlKey
		{
			get { return _Event.GetCtrlKeyAttribute(); }
		}
		
		/// <summary>
		/// true if the shift key was down when the mouse event was fired.
		/// </summary>
		public bool ShiftKey
		{
			get { return _Event.GetShiftKeyAttribute(); }
		}
	};
}
