using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using Gecko.DOM;

namespace Gecko
{
	/// <summary>
	/// Provides a base class for DOM nodes.
	/// </summary>
	public class GeckoNode
	{
		static GeckoWrapperCache<nsIDOMNode, GeckoNode> m_nodeCache = new GeckoWrapperCache<nsIDOMNode, GeckoNode>(CreateNodeWrapper);


		#region ctor & creation methods
		internal GeckoNode(nsIDOMNode domObject)
		{
			_DomObject = domObject;
		}

		internal static GeckoNode Create(nsIDOMNode domObject)
		{
			return m_nodeCache.Get(domObject);
		}

		internal static GeckoNode CreateNodeWrapper(nsIDOMNode domObject)
		{
			// if null -> return null
			if (domObject == null) return null;
			var nodeType = ( NodeType ) domObject.GetNodeTypeAttribute();
			// by nodeType we can find proper wrapper faster, than perform QueryInterface
			switch ( nodeType )
			{
				case NodeType.Element:
					nsIDOMHTMLElement element = Xpcom.QueryInterface<nsIDOMHTMLElement>(domObject);
					if (element != null) return GeckoElement.Create(element);
					break;
				case NodeType.Attribute:
					nsIDOMAttr attr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
					if (attr != null) return GeckoAttribute.CreateAttributeWrapper(attr);
					break;
				case NodeType.Comment:
					nsIDOMComment comment = Xpcom.QueryInterface<nsIDOMComment>(domObject);
					if (comment != null) return GeckoComment.CreateCommentWrapper(comment);
					break;
				case NodeType.DocumentFragment:
					nsIDOMDocumentFragment fragment = Xpcom.QueryInterface<nsIDOMDocumentFragment>(domObject);
					if (fragment != null) return DOM.DocumentFragment.CreateDocumentFragmentWrapper( fragment );
					break;
			}
			// if fast method is unsuccessful try old method :)
			return OldCreateWrapper( domObject );
		}

		internal static GeckoNode OldCreateWrapper(nsIDOMNode domObject)
		{
			if (domObject == null)
				return null;
			nsIDOMHTMLElement element = Xpcom.QueryInterface<nsIDOMHTMLElement>(domObject);
			if (element != null)
				return GeckoElement.Create(element);

			nsIDOMAttr attr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
			if (attr != null)
				return GeckoAttribute.CreateAttributeWrapper(attr);

			nsIDOMComment comment = domObject as nsIDOMComment;
			if (comment != null)
				return GeckoComment.CreateCommentWrapper(comment);

			return new GeckoNode(domObject);
		}
		#endregion


		/// <summary>
		/// Gets the underlying XPCOM object.
		/// </summary>
		public nsIDOMNode DomObject
		{
			get { return _DomObject; }
		}
		nsIDOMNode _DomObject;

		public override bool Equals(object obj)
		{
			if (this == obj)
				return true;
			else if (obj is GeckoNode)
				return this.GetHashCode() == (obj as GeckoNode).GetHashCode();

			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			IntPtr pUnk = Marshal.GetIUnknownForObject(this._DomObject);
			try
			{
				return pUnk.GetHashCode();
			}
			finally
			{
				if (pUnk != IntPtr.Zero)
					Marshal.Release(pUnk);
			}
		}

		/// <summary>
		/// Gets the text contents of the node.
		/// </summary>
		public string TextContent
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetTextContentAttribute); }
			set { nsString.Set(((nsIDOMNode)_DomObject).SetTextContentAttribute, value); }
		}

		/// <summary>
		/// Gets or sets the value of the node.
		/// </summary>
		public string NodeValue
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetNodeValueAttribute); }
			set { nsString.Set(((nsIDOMNode)_DomObject).SetNodeValueAttribute, value); }
		}

		/// <summary>
		/// Gets a collection containing all child nodes of this node.
		/// </summary>
		public GeckoNodeCollection ChildNodes
		{
			get { return GeckoNodeCollection.Create(_DomObject.GetChildNodesAttribute()); }
		}

		public GeckoNode FirstChild { get { return GeckoNode.Create(_DomObject.GetFirstChildAttribute()); } }
		public GeckoNode LastChild { get { return GeckoNode.Create(_DomObject.GetLastChildAttribute()); } }
		public GeckoNode NextSibling { get { return GeckoNode.Create(_DomObject.GetNextSiblingAttribute()); } }
		public GeckoNode PreviousSibling { get { return GeckoNode.Create(_DomObject.GetPreviousSiblingAttribute()); } }
		public bool HasChildNodes { get { return _DomObject.HasChildNodes(); } }
		public bool HasAttributes { get { return _DomObject.HasAttributes(); } }

		public GeckoDocument OwnerDocument { get { return GeckoDocument.Create(Xpcom.QueryInterface<nsIDOMHTMLDocument>(_DomObject.GetOwnerDocumentAttribute())); } }

		public GeckoNode AppendChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");

			_DomObject.AppendChild(node._DomObject);
			return node;
		}

		public GeckoNode CloneNode(bool deep)
		{
			return GeckoNode.Create(_DomObject.CloneNode(deep));
		}

		public GeckoNode InsertBefore(GeckoNode newChild, GeckoNode before)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (before == null)
				throw new ArgumentNullException("before");

			_DomObject.InsertBefore(newChild._DomObject, before._DomObject);
			return newChild;
		}

		public GeckoNode RemoveChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");

			_DomObject.RemoveChild(node._DomObject);
			return node;
		}

		public GeckoNode ReplaceChild(GeckoNode newChild, GeckoNode oldChild)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (oldChild == null)
				throw new ArgumentNullException("oldChild");

			_DomObject.ReplaceChild(newChild._DomObject, oldChild._DomObject);
			return newChild;
		}

		public string NamespaceURI
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetNamespaceURIAttribute); }
		}

		public string Prefix
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetPrefixAttribute); }
		}

		public string LocalName
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetLocalNameAttribute); }
		}

		public GeckoNamedNodeMap Attributes
		{
			get { return new GeckoNamedNodeMap(_DomObject.GetAttributesAttribute()); }
		}

		private NodeType m_cachedType;

		public NodeType Type
		{
			get {
				if (m_cachedType != 0)
					return m_cachedType;

				return m_cachedType = (NodeType)_DomObject.GetNodeTypeAttribute(); 
			}
		}

		public GeckoNode ParentNode
		{
			get {
				return GeckoNode.Create(_DomObject.GetParentNodeAttribute());
			}
		}

		public GeckoElement ParentElement
		{
			get
			{
				nsIDOMNode node = _DomObject.GetParentNodeAttribute();
				while (node != null && !(node is nsIDOMElement))
					node = node.GetParentNodeAttribute();

				if (node == null)
					return null;

				return (GeckoElement)GeckoNode.Create(node);
			}
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoNode> GetNodes(string xpath)
		{
			nsIDOMXPathEvaluator evaluator = Xpcom.CreateInstance<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoNodeEnumerable(result);
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoElement> GetElements(string xpath)
		{
			nsIDOMXPathEvaluator evaluator = Xpcom.CreateInstance<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoElementEnumerable(result);
		}
	}
}
