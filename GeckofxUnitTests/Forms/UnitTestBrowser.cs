using System;
using System.Windows.Forms;
using GeckofxUnitTests.ExtensionMethods;

namespace GeckofxUnitTests.Forms
{
    public partial class UnitTestBrowser : Form
    {
        public UnitTestBrowser()
        {
            InitializeComponent();
        }

        private void AboutMemory_Load(object sender, EventArgs e)
        {
            wbUnitTest.Navigate("about:blank");
            wbMemory.Navigate("about:memory");
        }
    }
}
