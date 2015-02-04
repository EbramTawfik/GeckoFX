using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.IO.Native;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class ByteArrayInputStreamTests
	{		
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);			
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			
		}

		[Test]
		public void Available_InitializedStream_ReturnsNumberOfAvailableBytes()
		{
			byte[] data = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			ByteArrayInputStream stream = ByteArrayInputStream.Create(data);
			Assert.AreEqual(11, stream.Available());			
		}

		[Test]
		public void IsNonBlocking_InitializedStream_ReturnsTrue()
		{
			byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			ByteArrayInputStream stream = ByteArrayInputStream.Create(data);
			Assert.AreEqual(true, stream.IsNonBlocking());
		}

		[Test]
		public void Read_InitializedStream_ShouldReturnCorrectResults()
		{
			byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			ByteArrayInputStream stream = ByteArrayInputStream.Create(data);
			IntPtr aBuf = Marshal.AllocCoTaskMem(1);

			// Read first byte
			stream.Read(aBuf, 1);
			byte result = Marshal.ReadByte(aBuf);
			Assert.AreEqual(0, result);

			// Read second byte.
			stream.Read(aBuf, 1);
			result = Marshal.ReadByte(aBuf);
			Assert.AreEqual(1, result);

			Marshal.FreeCoTaskMem(aBuf);
		}

		
	}

	[TestFixture]
	public class NativeInputStreamTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{

		}

		[Test]
		public void Available_InitializedStream_ReturnsNumberOfAvailableBytes()
		{
			byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			NativeInputStream stream = NativeInputStream.Create(data);
			Assert.AreEqual(11, stream.Available());
		}

		[Test]
		public void IsNonBlocking_InitializedStream_ReturnsTrue()
		{
			byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			NativeInputStream stream = NativeInputStream.Create(data);
			Assert.AreEqual(true, stream.IsNonBlocking());
		}

		[Test]
		public void Read_InitializedStream_ShouldReturnCorrectResults()
		{
			byte[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			NativeInputStream stream = NativeInputStream.Create(data);
			IntPtr aBuf = Marshal.AllocCoTaskMem(1);

			// Read first byte
			stream.Read(aBuf, 1);
			byte result = Marshal.ReadByte(aBuf);
			Assert.AreEqual(0, result);

			// Read second byte.
			stream.Read(aBuf, 1);
			result = Marshal.ReadByte(aBuf);
			Assert.AreEqual(1, result);

			Marshal.FreeCoTaskMem(aBuf);
		}


	}
}