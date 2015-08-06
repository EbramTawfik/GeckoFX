using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GeckofxUnitTests
{
    [TestFixture]
    class PromptFactoryFactoryTests
    {
        [Test]
        public void NormalUsage()
        {
            Gecko.PromptFactoryFactory.Init();
            Gecko.PromptFactoryFactory.Shutdown();
        }

        [Test]
        public void ShutdownCalledWithoutInit()
        {            
            Gecko.PromptFactoryFactory.Shutdown();
        }

        [Test]
        public void ShutdownCalledTwice()
        {
            Gecko.PromptFactoryFactory.Init();
            Gecko.PromptFactoryFactory.Shutdown();
            Gecko.PromptFactoryFactory.Shutdown();
        }
    }
}
