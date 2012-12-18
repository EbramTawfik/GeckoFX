using Gecko.Interop;

namespace Gecko.DOM
{
	public sealed class DomEventTarget
	{
		private InstanceWrapper<nsIDOMEventTarget> _target;
		
		private DomEventTarget(nsIDOMEventTarget target)
		{
			_target = new InstanceWrapper<nsIDOMEventTarget>( target );
		}

		public static DomEventTarget Create(nsIDOMEventTarget target)
		{
			return new DomEventTarget( target );
		}

		public nsIDOMEventTarget NativeObject
		{
			get { return _target.Instance; }
		}

		public void DispatchEvent(DomEventArgs @event)
		{
			_target.Instance.DispatchEvent( @event.DomEvent );
		}

	}
}