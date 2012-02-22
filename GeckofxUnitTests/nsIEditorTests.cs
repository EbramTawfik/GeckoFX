using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class nsIEditorTests
	{
		private GeckoWebBrowser _browser;
		private nsIEditor _editor;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);

			LoadEditableHtml("<div>hello world</div>");

			_editor = _browser.Editor;
			Assert.IsNotNull(_editor);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			_browser.Dispose();
		}

		/// <summary>
		/// Helper method to initalize a content editable document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal void LoadEditableHtml(string innerHtml)
		{
			LoadHtml(innerHtml, true);
		}

		/// <summary>
		/// Helper method to initalize a content editable document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		/// <param name="editable"></param>
		private void LoadHtml(string innerHtml, bool editable)
		{
			string contenteditable = editable ? "contenteditable=\"true\"" : string.Empty;
			_browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

							 + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

							 + "<body " + contenteditable + ">" + innerHtml + "</body></html>");

			_browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}

		class StubOutputStream : nsIOutputStream
		{

			public StringBuilder _result = new StringBuilder();

			public void Close()
			{
				throw new NotImplementedException();
			}

			public void Flush()
			{
				throw new NotImplementedException();
			}

			public uint Write(IntPtr aBuf, uint aCount)
			{
				_result.Append(Marshal.PtrToStringAnsi(aBuf));				
				return aCount;
			}

			public uint WriteFrom(nsIInputStream aFromStream, uint aCount)
			{
				throw new NotImplementedException();
			}

			public uint WriteSegments(IntPtr aReader, IntPtr aClosure, uint aCount)
			{
				throw new NotImplementedException();
			}

			public bool IsNonBlocking()
			{
				throw new NotImplementedException();
			}
		}

		[Test]
		public void OutputToStream_OutputEditableBody_BodyAndContentWritenToStream()
		{
			using(nsAString formatType = new nsAString("text/html"))
			{
				var outputStream = new StubOutputStream();
				_editor.OutputToStream(outputStream, formatType, new nsACString("utf8"), 8);
				Assert.AreEqual("<body contenteditable=\"true\"><div>hello world</div></body>", outputStream._result.ToString());
			}
		}

	}
}
