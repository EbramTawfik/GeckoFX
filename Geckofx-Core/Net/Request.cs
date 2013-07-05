using System;
using System.Linq;
using System.Text;

namespace Gecko.Net
{
	public class Request
	{
		private InstanceWrapper<nsIRequest> _request;

		protected Request(nsIRequest request)
		{
			_request = new InstanceWrapper<nsIRequest>( request );
		}

		public nsIRequest NativeRequest
		{
			get { return _request.Instance; }
		}

		#region Wrapper functions and properties
		/// <summary>
		/// The name of the request.  Often this is the URI of the request.
		/// </summary>
		public string Name
		{
			get { return nsString.Get( _request.Instance.GetNameAttribute ); }
		}
			
		public bool IsPending
		{
			get { return _request.Instance.IsPending(); }
		}

		public int Status
		{
			get { return _request.Instance.GetStatusAttribute(); }
		}

		public void Cancel(int aStatus)
		{
			_request.Instance.Cancel( aStatus );
		}

		public void Suspend()
		{
			_request.Instance.Suspend();
		}

		public void Resume()
		{
			_request.Instance.Resume();
		}

		public LoadGroup LoadGroup
		{
			get { return LoadGroup.Create( _request.Instance.GetLoadGroupAttribute() ); }
			set { _request.Instance.SetLoadGroupAttribute( value == null ? null : value._loadGroup ); }
		}

		public uint LoadFlags
		{
			get { return _request.Instance.GetLoadFlagsAttribute(); }
			set { _request.Instance.SetLoadFlagsAttribute( value ); }
		}
		#endregion

		public override int GetHashCode()
		{
			return _request.Instance.GetHashCode();
		}



		public static Request Create( nsIRequest request )
		{
			if ( request is nsIChannel )
			{
				return Channel.Create( ( nsIChannel ) request );
			}
			return new Request( request );
		}
	}
}
