using System;
using Xunit;
using System.Collections.Generic;
using NSS_Koans;

namespace NSS_Koans_Tester
{

    public class Dictionaries
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutDictionariesAddingToADictionary()
        {
            //Dictionary<TKey, TValue> is .Net's key value store. The key and the value do not need to be the same types.
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Assert.Equal(FILL_ME_IN, dictionary.Count);
            dictionary.Add(1,"one");
            Assert.Equal(FILL_ME_IN, dictionary.Count);
        }

        [Fact]
        public void AboutDictionariesAccessingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");
            dictionary.Add("two", "dos");
            //The most common way to locate data is with the subscript notation.
            Assert.Equal(FILL_ME_IN, dictionary["one"]);
            Assert.Equal(FILL_ME_IN, dictionary["two"]);
        }

        [Fact]
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

            Assert.Equal(FILL_ME_IN, value);
        }

        [Fact]
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

            Assert.Equal(FILL_ME_IN, value);
        }


        [Fact]
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
            Assert.Equal(FILL_ME_IN, result);
        }

        [Fact]
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
            Assert.Equal(FILL_ME_IN, result);
        }

        [Fact]
        public void AboutDictionariesTryGetValueForMissingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");

            string result;
            if (!dictionary.TryGetValue("two", out result))
            {
                result = "dos";
            }
            Assert.Equal(FILL_ME_IN, result);
        }

        [Fact]
        public void AboutDictionariesInitializingADictionary()
        {
            //Although it is not common, you can initialize a dictionary...
            var dictionary = new Dictionary<string, string> { { "one", "uno" }, { "two", "dos" } };
            Assert.Equal(FILL_ME_IN, dictionary["one"]);
            Assert.Equal(FILL_ME_IN, dictionary["two"]);
        }

        [Fact]
        public void AboutDictionariesModifyingData()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "uno");
            dictionary.Add("two", "dos");
            dictionary.Add("one", "ein");
            Assert.Equal("un", dictionary["one"]);
        }

        [Fact]
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

            Assert.Equal(FILL_ME_IN, one.ContainsKey("jim"));
            Assert.Equal(FILL_ME_IN, one.ContainsKey("jenny"));
            Assert.Equal(FILL_ME_IN, one.ContainsKey("amy"));
            Assert.Equal(FILL_ME_IN, one["jim"]);
        }
    }
}
