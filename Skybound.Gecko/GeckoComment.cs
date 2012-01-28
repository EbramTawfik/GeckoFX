using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using Gecko.DOM;

namespace Gecko
{
	/// <summary>
	/// Represents a DOM Comment
	/// </summary>
	public class GeckoComment : GeckoNode
	{
		nsIDOMComment DomComment;

		internal GeckoComment(nsIDOMComment comment)
			: base(comment)
		{
			DomComment = comment;
		}

		internal static GeckoComment Create(nsIDOMComment comment)
		{
			return (comment == null) ? null : new GeckoComment(comment);
		}

		public string GetData()
		{
			return nsString.Get(DomComment.GetDataAttribute);			
		}

		public void SetData(string data)
		{
			nsString.Set(DomComment.SetDataAttribute, data);
		}

		public uint GetLength()
		{
			return DomComment.GetLengthAttribute();
		}

		public string SubstringData(uint offset, uint count)
		{
			using (nsAString retval = new nsAString())
			{
				DomComment.SubstringData(offset, count, retval);
				return retval.ToString();
			}
		}

		public void AppendData(string arg)
		{
			nsString.Set(DomComment.AppendData, arg);
		}

		public void InsertData(uint offset, string arg)
		{
			using (nsAString str = new nsAString(arg))
			{
				DomComment.InsertData(offset, str);
			}
		}

		public void DeleteData(uint offset, uint count)
		{
			DomComment.DeleteData(offset, count);
		}

		public void ReplaceData(uint offset, uint count, string arg)
		{
			using (nsAString str = new nsAString(arg))
			{
				DomComment.ReplaceData(offset, count, str);
			}
		}
	}
}