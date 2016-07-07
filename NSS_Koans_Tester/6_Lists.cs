using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class Lists : Koan
    {
        [TestMethod]
        public void AboutListsListsAreTyped()
        {
            List<int> integers = new List<int>();
            Assert.AreEqual("The test below is going to pass as is",
                "but go ahead an fix it so it makes sense");//then comment this test out =-)
            CollectionAssert.AreEqual(integers, new List<FillMeIn>());
        }

        [TestMethod]
        public void AboutListsOneWayToCreateAList()
        {
            List<char> characterList = new List<char>() { 'a', 'b', 'c' };
            Assert.AreEqual(FILL_ME_IN, characterList[0]);
            Assert.AreEqual(FILL_ME_IN, characterList[1]);
            Assert.AreEqual(FILL_ME_IN, characterList[2]);

        }

        [TestMethod]
        public void AboutListsAnotherWayToCreateAList()
        {
            List<char> characterList = new List<char>();
            characterList.Add('a');
            characterList.Add('b');
            characterList.Add('c');

            Assert.AreEqual(FILL_ME_IN, characterList[0]);
            Assert.AreEqual(FILL_ME_IN, characterList[1]);
            Assert.AreEqual(FILL_ME_IN, characterList[2]);
        }

        [TestMethod]
        public void AboutListsCanLoopThroughAListWithForEach()
        {
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int theLatestInteger = 33;
            foreach(int integer in integerList)
            {
                if(integer % 3 == 0)
                {
                    theLatestInteger = integer;
                }
            }

            Assert.AreEqual(FILL_ME_IN, theLatestInteger);
        }

        [TestMethod]
        public void AboutListsCanGetTheNumberOfItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.AreEqual(FILL_ME_IN, stringList.Count);
        }

        [TestMethod]
        public void AboutListsCanRemoveAllItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.AreEqual(FILL_ME_IN, stringList.Count);
            stringList.Clear();
            Assert.AreEqual(FILL_ME_IN, stringList.Count);

        }

        [TestMethod]
        public void AboutListsCanCheckToSeeWhatAListContains()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            bool stringListItems = stringList.Contains("banana");
            bool notStringListItems = stringList.Contains("grapes");
            Assert.IsTrue(FillIn);
            Assert.IsFalse(FillIn);

        }

        [TestMethod]
        public void AboutListsListsCanBeConvertedToStringsWithStringBuilder()
        {
            List<string> nss = new List<string>() { "nashville", "software", "school"};
            StringBuilder builder = new StringBuilder();
            foreach (string word in nss)
            {
                builder.Append(word).Append(" ");
            }
            string result = builder.ToString();

            Assert.AreEqual(FILL_ME_IN, result);
            
        }

        [TestMethod]
        public void AboutListsListsCanBeConvertedToStringsWithJoin()
        {
            List<string> dogs = new List<string>();
            dogs.Add("Aigi");
            dogs.Add("Spitz");
            dogs.Add("Mastiff"); 
            dogs.Add("Finnish Spitz"); 
            dogs.Add("Briard"); 

            string dogString = string.Join(", ", dogs.ToArray());
            Assert.AreEqual(FILL_ME_IN, dogString);
        }

        [TestMethod]
        public void AboutListsABetterDynamicSizeContainer()
        {
            //The "T" in the definition of List<T> is the type argument. You cannot declare an instace of List<T> without also
            //supplying a type in place of T.
            var list = new List<int>();
            Assert.AreEqual(FILL_ME_IN, list.Count);

            list.Add(42);
            Assert.AreEqual(FILL_ME_IN, list.Count);

            //Now just like int[], you can have a type safe dynamic sized container
            //list.Add("fourty two"); //<--Unlike ArrayList this is illegal.

            //List<T> also solves the boxing/unboxing issues of ArrayList. Check out the Arrays test class around line 127 if you've already forgotten about arraylists.
        }
        public class Widget
        {
            //yup, we just totally created our own type in the middle of this test class ;-)
        }

        [TestMethod]
        public void AboutListsListWorksWithAnyType()
        {
            //Just as with Array, list will work with any type
            List<Widget> list = new List<Widget>();
            list.Add(new Widget());
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void AboutListsInitializingWithValues()
        {
            //Like array you can create a list with an initial set of values easily
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void AboutListsAddMultipleItems()
        {
            //You can add multiple items to a list at once
            List<int> list = new List<int>();
            list.AddRange(new[] { 1, 2, 3 });
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void AboutListsRandomAccess()
        {
            //Just as with array, you can use the subscript notation to access any element in a list.
            List<int> list = new List<int> { 5, 6, 7 };
            Assert.AreEqual(FILL_ME_IN, list[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(FillMeIn))] //<--- Here's where you need to fill something in
        public void AboutListsBeyondTheLimits()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            //You cannot attempt to get data that doesn't exist
            Assert.AreEqual(4, list[3]);
        }

        [TestMethod]
        public void AboutListsConvertingToFixedSize()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            CollectionAssert.AreEqual(Fill_In, list.ToArray());
        }

        [TestMethod]
        public void AboutListsInsertingInTheMiddle()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            list.Insert(1, 6);
            CollectionAssert.AreEqual(Fill_In, list.ToArray());
        }

        [TestMethod]
        public void AboutListsRemovingItems()
        {
            List<int> list = new List<int> { 2, 1, 2, 3 };
            list.Remove(2);
            CollectionAssert.AreEqual(Fill_In, list.ToArray());
        }

    }
}
