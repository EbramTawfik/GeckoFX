using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using GeckofxUnitTests.Common;
using NUnit.Framework;

namespace GeckofxUnitTests
{

    /// <summary>
    /// GeckoPreferences Tests
    /// </summary>
    [TestFixture]   
    class GeckoPreferencesTests
    {
        [TestCase("gfx.font_rendering.graphite.enabled", true)]
        [TestCase("dom.max_script_run_time", 0)]        
        [TestCase("browser.xul.error_pages.enabled", false)]
        [TestCase("accessibility.force_disabled", 1)]
        [TestCase("middlemouse.paste", false)]
        [TestCase("middlemouse.paste", false)]
        [TestCase("capability.principal.codebase.p0.granted", "UniversalXPConnect")]
        [TestCase("capability.principal.codebase.p0.granted", "file://")]
        [TestCase("capability.principal.codebase.p0.subjectName", "")]
        [TestCase("security.fileuri.strict_origin_policy", false)]
        [TestCase("layout.css.devPixelsPerPx", "1.0")]
        [TestCase("breakpad.reportURL", "")]
        [TestCase("breakpad.reportURL", "abcdefghijklmnopqrstuvwxyz!@#$%^&*()")]
        [TestCase("breakpad.reportURL", "\u00fe\u00ff\uf323")]
        public void Set<T>(string pref, T value)
        {
            var originalValue = GeckoPreferences.User[pref];
            try
            {
                GeckoPreferences.User[pref] = value;

                Assert.AreEqual(value, GeckoPreferences.User[pref]);
            }
            finally
            {
                if (originalValue != null)
                    GeckoPreferences.User[pref] = originalValue;
                else if (default(T) == null)
                    GeckoPreferences.User[pref] = String.Empty;
                else
                    GeckoPreferences.User[pref] = default(T);                 
            }

        }
    }
}
