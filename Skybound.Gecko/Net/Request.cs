using System;
using System.Linq;
using System.Text;

namespace Gecko.Net
{
	public class Request
	{
		internal nsIRequest _request;

		internal Request(nsIRequest request)
		{
			_request = request;
		}
		
		/// <summary>
		/// The name of the request.  Often this is the URI of the request.
		/// </summary>
		public string Name
		{
			get { return nsString.Get( _request.GetNameAttribute ); }
		}
			
		public bool IsPending
		{
			get { return _request.IsPending(); }
		}

		public int Status
		{
			get { return _request.GetStatusAttribute(); }
		}

		public void Cancel(int aStatus)
		{
			_request.Cancel( aStatus );
		}

		public void Suspend()
		{
			_request.Suspend();
		}

		public void Resume()
		{
			_request.Resume();
		}
	
		public LoadGroup LoadGroup
		{
			get { return new LoadGroup(_request.GetLoadGroupAttribute()); }
			set{_request.SetLoadGroupAttribute( value._loadGroup );}
		}

		public uint LoadFlags
		{
			get { return _request.GetLoadFlagsAttribute(); }
			set{_request.SetLoadFlagsAttribute( value );}
		}

	}
}
