using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.IO;
using System.Diagnostics;

namespace GeckofxUnitTests
{
    [TestFixture]
    [Platform(Exclude="Win", Reason = "Linux Specific memory checking")]
    internal class MemoryTests
    {
        static nsIMemory _memoryService;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            WindowMediator.Disable = true;
            if (_memoryService == null)
                _memoryService = Xpcom.GetService<nsIMemory>("@mozilla.org/xpcom/memory-service;1");
        }

        [Test]
        public void UncreatedGeckofxControl()
        {
            Func<GeckoWebBrowser> operation = () => { return new GeckoWebBrowser(); };
            Action<GeckoWebBrowser> cleanupOperation = (browser) => browser.Dispose();

            Warmup(operation, cleanupOperation);

            MemorySnapShot start;
            MemorySnapShot end;
            var result = PerformTest(operation, cleanupOperation, 800, out start, out end);

            Assert.AreEqual(Leaks.None, result, String.Format("leak = {0}, \nstart = {1} \nend = {2}", result, start, end));
        }

        [Test]
        public void CreatedGeckofxControl()
        {
            Func<GeckoWebBrowser> operation = () => { 
                var b = new GeckoWebBrowser(); 
                var unused = b.Handle;
                return b;
            };
            Action<GeckoWebBrowser> cleanupOperation = (browser) => browser.Dispose();

            Warmup(operation, cleanupOperation);

            MemorySnapShot start;
            MemorySnapShot end;
            var result = PerformTest(operation, cleanupOperation, 220, out start, out end);

            Assert.AreEqual(Leaks.None, result, String.Format("leak = {0}, \nstart = {1} \nend = {2}", result, start, end));
        }

        //[Test]
        public void NavigatedGeckofxControl()
        {
            Func<GeckoWebBrowser> operation = () => { 
                var b = new GeckoWebBrowser(); 
                b.TestLoadHtml("hello world");
                return b;
            };
            Action<GeckoWebBrowser> cleanupOperation = (browser) => browser.Dispose();

            Warmup(operation, cleanupOperation);

            MemorySnapShot start;
            MemorySnapShot end;
            var result = PerformTest(operation, cleanupOperation, 20, out start, out end);

            Assert.AreEqual(Leaks.None, result, String.Format("leak = {0}, \nstart = {1} \nend = {2}", result, start, end));
        }

        #region HelperMethods

        private void Warmup<T>(Func<T> create, Action<T> cleanup)
        {
            for(int i =0 ; i < 2; i++)
            {
                var o = create();
                cleanup(o);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if memleak</returns>
        /// <param name="create"></param>
        /// <param name="cleanup"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <typeparam name="T"></typeparam>
        private Leaks PerformTest<T>(Func<T> create, Action<T> cleanup, int operationCount, out MemorySnapShot start, out MemorySnapShot end)
        {
            for (int i = 0; i < 5; i++)
            {
                Application.DoEvents();
                Application.RaiseIdle(EventArgs.Empty);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                _memoryService.HeapMinimize(true);
            }

            start = MemorySnapShot.Record();

            for(int i = 0 ; i < operationCount; i++)
            {
                var o = create();
                cleanup(o);
                o = default(T);
            }

            for (int i = 0; i < 5; i++)
            {
                Application.DoEvents();
                Application.RaiseIdle(EventArgs.Empty);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                _memoryService.HeapMinimize(true);
            }

            end = MemorySnapShot.Record();

            return IsMemoryLeak(start, end);
        }

        [Flags]
        enum Leaks
        {
            None = 0,
            Managed = 0x1,
            Heap = 0x2,
        };

        private Leaks IsMemoryLeak(MemorySnapShot start, MemorySnapShot end)
        {
            var ret = Leaks.None;

            // Check for managed memory 
            if ((int)MemorySnapShot.ToMb(end.MonoManagedMemory) > (int)MemorySnapShot.ToMb(start.MonoManagedMemory))            
                ret |= Leaks.Managed;

            // Check for help leaks.
            if ((int)MemorySnapShot.ToMb(end.DataAndStack) > (int)MemorySnapShot.ToMb(start.DataAndStack))  
                ret |= Leaks.Heap;

            return ret;
        }


       

        struct MemorySnapShot
        {
            const int StandardLinuxPageSize = 4096;

            // All these fields are in bytes.
            public long TotalProgSize;
            public long Resident;
            public long Share;
            public long Text;
            public long DataAndStack;
            public long MonoManagedMemory;

            public static MemorySnapShot Record()
            {
                var items = GetProcInfo(Process.GetCurrentProcess(), "statm").Split(' ');
                var itemsArray = items.Select((x) => (long)(long.Parse(x) * StandardLinuxPageSize)).ToArray();

                return new MemorySnapShot()
                {
                    TotalProgSize = itemsArray[0], 
                    Resident = itemsArray[1],
                    Share = itemsArray[2],
                    Text = itemsArray[3],
                    DataAndStack = itemsArray[5],
                    MonoManagedMemory = GC.GetTotalMemory(true)
                };
            }

            public static double ToMb(long bytes)
            {
                return bytes / 1024.0 / 1024;
            }

            public string CompareToBaseLine(MemorySnapShot baseLine)
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "total prog size : ", (long)ToMb(TotalProgSize), (long)ToMb(TotalProgSize - baseLine.TotalProgSize));
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "resident        : ", (long)ToMb(Resident), (long)ToMb(Resident - baseLine.Resident));
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "share           : ", (long)ToMb(Share), (long)ToMb(Share - baseLine.Share));
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "text            : ", (long)ToMb(Text), (long)ToMb(Text - baseLine.Text));
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "data + stack    : ", (long)ToMb(DataAndStack), (long)ToMb(DataAndStack - baseLine.DataAndStack));
                sb.AppendFormat(" {0} {1,5}Mbs change from base {2,5}Mbs\n", "Mono Mem Size:  : ", (long)ToMb(MonoManagedMemory), (long)ToMb(MonoManagedMemory - baseLine.MonoManagedMemory));

                return sb.ToString();
            }

            public override string ToString()
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendFormat(" {0} {1,5}Mbs\n", "total prog size : ", (long)ToMb(TotalProgSize));
                sb.AppendFormat(" {0} {1,5}Mbs\n", "resident        : ", (long)ToMb(Resident));
                sb.AppendFormat(" {0} {1,5}Mbs\n", "share           : ", (long)ToMb(Share));
                sb.AppendFormat(" {0} {1,5}Mbs\n", "text            : ", (long)ToMb(Text));
                sb.AppendFormat(" {0} {1,5}Mbs\n", "data + stack    : ", (long)ToMb(DataAndStack));
                sb.AppendFormat(" {0} {1,5}Mbs\n", "Mono Mem Size:  : ", (long)ToMb(MonoManagedMemory));

                return sb.ToString();
            }

            public static bool operator ==(MemorySnapShot c1, MemorySnapShot c2) 
            {
                return c1.Equals(c2);
            }

            public static bool operator !=(MemorySnapShot c1, MemorySnapShot c2) 
            {
                return !c1.Equals(c2);
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MemorySnapShot))
                    return false;

                var rhs = (MemorySnapShot)obj;

                return (TotalProgSize == rhs.TotalProgSize && 
                        Resident == rhs.Resident &&
                        Share == rhs.Share &&
                        Text == rhs.Text &&
                        DataAndStack == rhs.DataAndStack &&
                        MonoManagedMemory == rhs.MonoManagedMemory);
            }

            // only here to get rid of compiler warning
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// Linux only - other platforms return null.
            /// Returns the contents of the the /proc/[pid]/[filename].
            /// </summary>
            /// <param name="process"></param>
            /// <param name="filename"></param>
            /// <returns></returns>
            private static string GetProcInfo(Process process, string filename)
            {
                if (process == null)
                    throw new ArgumentNullException("process");

                if (String.IsNullOrEmpty(filename))
                    throw new ArgumentException("filename");

                return File.ReadAllText(String.Format("/proc/{0}/{1}", process.Id, filename));
            }
        }

        #endregion
    }
}

