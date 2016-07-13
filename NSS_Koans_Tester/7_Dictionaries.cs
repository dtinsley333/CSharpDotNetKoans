using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class Dictionaries : Koan
    {

        [TestMethod]
        public void AboutDictionariesAddingToADictionary()
        {
            //Dictionary<TKey, TValue> is .Net's key value store. The key and the value do not need to be the same types.
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Assert.AreEqual(FILL_ME_IN, dictionary.Count);
            dictionary.Add(1,"one");
            Assert.AreEqual(FILL_ME_IN, dictionary.Count);
        }

        [TestMethod]
        public void AboutDictionariesAccessingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");
            dictionary.Add("two", "dos");
            //The most common way to locate data is with the subscript notation.
            Assert.AreEqual(FILL_ME_IN, dictionary["one"]);
            Assert.AreEqual(FILL_ME_IN, dictionary["two"]);
        }

        [TestMethod]
        public void AboutDictionariesCheckIfADictionaryContainsAKey()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(53, "phone");
            dictionary.Add(2, "laptop");
            dictionary.Add(3, "TV");
            dictionary.Add(4, "computer");

            string value = string.Empty;

            if (dictionary.ContainsKey(1))
            {
                 value = dictionary[1];
            }

            if (!dictionary.ContainsKey(1))
            {
                 value = "value not found";
            }

            Assert.AreEqual(FILL_ME_IN, value);
        }

        [TestMethod]
        public void AboutDictionariesCheckIfADictionaryContainsAValue()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "phone");
            dictionary.Add(2, "laptop");
            dictionary.Add(3, "TV");
            dictionary.Add(4, "computer");

            string value = string.Empty;

            if (dictionary.ContainsValue("desk"))
            {
                value = dictionary[1];
            }

            if (!dictionary.ContainsValue("desk"))
            {
                value = "value not found";
            }

            Assert.AreEqual(FILL_ME_IN, value);
        }


        [TestMethod]
        public void AboutDictionariesCatchingMissingData()
        {
            //To deal with the throw when data is not there, you could wrap the data access in a try/catch block...
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");
            string result;
            try
            {
                result = dictionary["two"];
            }
            catch (Exception ex)
            {
                result = "dos";
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [TestMethod]
        public void AboutDictionariesPreCheckForMissingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");

            string result;
            if (dictionary.ContainsKey("two"))
            {
                result = dictionary["two"];
            }
            else
            {
                result = "dos";
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [TestMethod]
        public void AboutDictionariesTryGetValueForMissingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");

            string result;
            if (!dictionary.TryGetValue("two", out result))
            {
                result = "dos";
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [TestMethod]
        public void AboutDictionariesInitializingADictionary()
        {
            //Although it is not common, you can initialize a dictionary...
            var dictionary = new Dictionary<string, string> { { "one", "uno" }, { "two", "dos" } };
            Assert.AreEqual(FILL_ME_IN, dictionary["one"]);
            Assert.AreEqual(FILL_ME_IN, dictionary["two"]);
        }

        [TestMethod]
        [ExpectedException(typeof(FillMeIn))] //<--- Here's where you need to fill something in
        public void AboutDictionariesModifyingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");
            dictionary.Add("two", "dos");
            dictionary.Add("one", "ein");
            Assert.AreEqual("un", dictionary["one"]);
        }

        [TestMethod]
        public void AboutDictionariesCombiningDictionaries()
        {
            Dictionary<string, int> one = new Dictionary<string, int>();
            one.Add("jim", 53);
            one.Add("amy", 20);
            one.Add("dan", 23);
            

            Dictionary<string, int> two = new Dictionary<string, int>();
            two.Add("jim", 54);
            two.Add("jenny", 26);

            foreach (KeyValuePair<string, int> item in two)
            {
                one[item.Key] = item.Value;
            }

            Assert.AreEqual(FILL_ME_IN, one.ContainsKey("jim"));
            Assert.AreEqual(FILL_ME_IN, one.ContainsKey("jenny"));
            Assert.AreEqual(FILL_ME_IN, one.ContainsKey("amy"));
            Assert.AreEqual(Fill_In_Number, one["jim"]);
        }
    }
}
