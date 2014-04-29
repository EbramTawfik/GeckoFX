using System.Runtime.CompilerServices;

namespace Gecko.Certificates
{
	public sealed class CertTreeItem
	{
		private InstanceWrapper<nsICertTreeItem> _certTreeItem;

		internal CertTreeItem(nsICertTreeItem certTreeItem)
		{
			_certTreeItem = new InstanceWrapper<nsICertTreeItem>( certTreeItem );
		}

		public Certificate Certificate
		{
			get { return Certificate.Create( _certTreeItem.Instance.GetCertAttribute() ); }
		}

		public string HostPort
		{
			get { return nsString.Get(_certTreeItem.Instance.GetHostPortAttribute); }
		}
	}
}