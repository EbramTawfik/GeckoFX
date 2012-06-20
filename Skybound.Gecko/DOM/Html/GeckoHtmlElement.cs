using System.Drawing;

namespace Gecko
{
	/// <summary>
	/// Represents a DOM HTML element.
	/// </summary>
	public class GeckoHtmlElement
		: GeckoElement
	{
		internal GeckoHtmlElement(nsIDOMHTMLElement element)
			: base(element)
		{
			this.DomElement = element;
			this.DomNSElement = (nsIDOMNSElement)element;
		}
		
		internal static GeckoHtmlElement Create(nsIDOMHTMLElement element)
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor(element);
		}

		internal static T Create<T>(nsIDOMHTMLElement element) where T : GeckoHtmlElement 
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor<T>(element);
		}
		
		nsIDOMHTMLElement DomElement;

		nsIDOMNSElement DomNSElement;
		
		/// <summary>
		/// Gets the inline style of the GeckoElement. 
		/// </summary>
		public GeckoStyle Style
		{
			get
			{
				return GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject).GetStyleAttribute());
			}
		}
		
		/// <summary>
		/// Gets the parent element of this one.
		/// </summary>
		public GeckoHtmlElement Parent
		{
			get
			{
				// note: the parent node could also be the document
				return GeckoHtmlElement.Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(DomElement.GetParentNodeAttribute()));
			}
		}


		
		/// <summary>
		/// Gets the value of the id attribute.
		/// </summary>
		public string Id
		{
			get { return nsString.Get(DomElement.GetIdAttribute); }
			set 
			{				
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("id");
				else
					nsString.Set(DomElement.SetIdAttribute, value); 
			}
		}
		
		/// <summary>
		/// Gets the value of the class attribute.
		/// </summary>
		public string ClassName
		{
			get { return nsString.Get(DomElement.GetClassNameAttribute); }
			set 
			{
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("class");
				else
					nsString.Set(DomElement.SetClassNameAttribute, value); 
			}
		}

		public void Blur()
		{
			DomElement.Blur();
		}

		public string AccessKey
		{
			get { return nsString.Get(DomElement.GetAccessKeyAttribute); }
			set { DomElement.SetAccessKeyAttribute(new nsAString(value)); }
		}

		public void Focus()
		{
			DomElement.Focus();
		}

		public void Click()
		{
			DomElement.Click();
		}

		public bool Draggable
		{
			get { return DomElement.GetDraggableAttribute(); }
			set { DomElement.SetDraggableAttribute(value); }
		}
	
		/// <summary>
		/// Get the value of the ContentEditable Attribute
		/// </summary>
		public string ContentEditable
		{
			get { return nsString.Get(DomElement.GetContentEditableAttribute); }
			set { nsString.Set(DomElement.GetContentEditableAttribute, value); }
		}
		
		public System.Drawing.Rectangle BoundingClientRect
		{
			get
			{
				nsIDOMClientRect domRect = DomNSElement.GetBoundingClientRect();
				var r = new Rectangle((int)domRect.GetLeftAttribute(), (int)domRect.GetTopAttribute(), (int)domRect.GetWidthAttribute(), (int)domRect.GetHeightAttribute());
				return r;				
			}
		}

		public int ScrollLeft { get { return DomNSElement.GetScrollLeftAttribute(); } set { DomNSElement.SetScrollLeftAttribute(value); } }
		public int ScrollTop { get { return DomNSElement.GetScrollTopAttribute(); } set { DomNSElement.SetScrollTopAttribute(value); } }
		public int ScrollWidth { get { return DomNSElement.GetScrollWidthAttribute(); } }
		public int ScrollHeight { get { return DomNSElement.GetScrollHeightAttribute(); } }
		public int ClientWidth { get { return DomNSElement.GetClientWidthAttribute(); } }
		public int ClientHeight { get { return DomNSElement.GetClientHeightAttribute(); } }

		public int OffsetLeft { get { return DomElement.GetOffsetLeftAttribute(); } }
		public int OffsetTop { get { return DomElement.GetOffsetTopAttribute(); } }
		public int OffsetWidth { get { return DomElement.GetOffsetWidthAttribute(); } }
		public int OffsetHeight { get { return DomElement.GetOffsetHeightAttribute(); } }
		
		public GeckoHtmlElement OffsetParent
		{
			get { return GeckoHtmlElement.Create((nsIDOMHTMLElement)DomElement.GetOffsetParentAttribute()); }
		}
		
		public void ScrollIntoView(bool top)
		{
			DomElement.ScrollIntoView(top, 1);
		}
		

		public bool Spellcheck
		{
			get { return DomElement.GetSpellcheckAttribute(); }
			set { DomElement.SetSpellcheckAttribute(value); }
		}

		public string InnerHtml
		{
			get { return nsString.Get(DomElement.GetInnerHTMLAttribute); }
			set { nsString.Set(DomElement.SetInnerHTMLAttribute, value); }
		}

		public virtual string OuterHtml
		{
			get { return nsString.Get(DomElement.GetOuterHTMLAttribute); }			
		}
		
		public int TabIndex
		{
			get { return DomElement.GetTabIndexAttribute(); }
			set { DomElement.SetTabIndexAttribute(value); }
		}

		public void InsertAdjacentHTML(string position, string text)
		{
			using(nsAString tempPos = new nsAString(position), tempText = new nsAString(text))
			{
				DomElement.InsertAdjacentHTML(tempPos, tempText);
			}
		}

		public void MozRequestFullScreen()
		{
			DomElement.MozRequestFullScreen();
		}
	}
}