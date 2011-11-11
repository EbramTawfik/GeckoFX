using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Skybound.Gecko;
using System.Windows.Forms;

namespace GeckofxUnitTests
{
	// Setting SetDictionaryAttribute ("en-US") throws NS_ERROR_FILE_NOT_FOUND on Linux.
	[TestFixture]
	[Platform(Exclude="Linux")]
	public class SpellCheckerEngineTests
	{
		const string Language = "en";
		const string DictionaryName = "en-US";

		mozISpellCheckingEngine m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			m_instance = Xpcom.GetService<mozISpellCheckingEngine>("@mozilla.org/spellchecker/engine;1");	
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetDictionaryAttribute_DictionaryHasBeenSet_ReturnsValidDictionaryName()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);
			Assert.AreEqual(DictionaryName, m_instance.GetDictionaryAttribute());
		}

		[Test]
		public void Check_ValidWord_ReturnsTrue()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);
			Assert.IsTrue(m_instance.Check("hello"));
		}

		[Test]
		public void Check_InValidWord_ReturnsFalse()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);
			Assert.IsFalse(m_instance.Check("ThisIsNotACorrectlySpeltWord"));
		}

		[Test]
		public void GetLanguageAttribute_DictionaryHasBeenSet_ReturnsLanguge()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);
			Assert.AreEqual(Language, m_instance.GetLanguageAttribute());			
		}

		[Test]
		public void GetPersonalDictionaryAttribute_PersonalDictionaryHasBeenSet_ReturnsValidInstance()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);

			var personalDictionary = new MockMozIPersonalDictionaryAcceptsAllWords();
			m_instance.SetPersonalDictionaryAttribute(personalDictionary);
			Assert.AreEqual(personalDictionary, m_instance.GetPersonalDictionaryAttribute());
		}

		[Test]
		public void Check_InValidWordWithPersonalDictionaryThatAcceptsAllWordsAdded_ReturnsTrue()
		{
			m_instance.SetDictionaryAttribute(DictionaryName);
			var personalDictionary = new MockMozIPersonalDictionaryAcceptsAllWords();
			m_instance.SetPersonalDictionaryAttribute(personalDictionary);
		
			Assert.IsTrue(m_instance.Check("ThisIsNotACorrectlySpeltWord"));
		}		
	}

	#region Mocks
	/// <summary>
	/// Mock PersonalDictionary That accepts all words.
	/// </summary>
	internal class MockMozIPersonalDictionaryAcceptsAllWords : mozIPersonalDictionary
	{

		public void Load()
		{

		}

		public void Save()
		{

		}

		public nsIStringEnumerator GetWordListAttribute()
		{
			throw new NotImplementedException();
		}

		public bool Check(string word, string lang)
		{
			return true;
		}

		public void AddWord(string word, string lang)
		{

		}

		public void RemoveWord(string word, string lang)
		{

		}

		public void IgnoreWord(string word)
		{

		}

		public void EndSession()
		{

		}

		public void AddCorrection(string word, string correction, string lang)
		{

		}

		public void RemoveCorrection(string word, string correction, string lang)
		{

		}

		public void GetCorrection(string word, ref System.IntPtr[] words, ref uint count)
		{			
		}
	}

	#endregion
}