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
        public void ListsAreTyped()
        {
            List<int> integers = new List<int>();
            Assert.AreEqual(integers, new List<FillMeIn>());
        }

        [TestMethod]
        public void OneWayToCreateAList()
        {
            List<char> characterList = new List<char>() { 'a', 'b', 'c' };
            Assert.AreEqual(FILL_ME_IN, characterList[0]);
            Assert.AreEqual(FILL_ME_IN, characterList[1]);
            Assert.AreEqual(FILL_ME_IN, characterList[2]);

        }

        [TestMethod]
        public void AnotherWayToCreateAList()
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
        public void CanLoopThroughAListWithForEach()
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

            Assert.AreEqual(9, theLatestInteger);
        }

        [TestMethod]
        public void CanGetTheNumberOfItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.AreEqual(FILL_ME_IN, stringList.Count);
        }

        [TestMethod]
        public void CanRemoveAllItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.AreEqual(FILL_ME_IN, stringList.Count);
            stringList.Clear();
            Assert.AreEqual(FILL_ME_IN, stringList.Count);

        }

        [TestMethod]
        public void MyTestMethod()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            bool stringListItems = stringList.Contains("banana");
            bool notStringListItems = stringList.Contains("grapes");
            Assert.IsTrue(FillIn);
            Assert.IsFalse(FillIn);

        }

        [TestMethod]
        public void ListsCanBeConvertedToStringsWithStringBuilder()
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
        public void ListsCanBeConvertedToStringsWithJoin()
        {
            List<string> dogs = new List<string>();
            dogs.Add("Aigi");
            dogs.Add("Spitz");
            dogs.Add("Mastiff"); 
            dogs.Add("Finnish Spitz"); 
            dogs.Add("Briard"); 

            string dogCsv = string.Join(",", dogs.ToArray());
            Assert.AreEqual(FILL_ME_IN, dogCsv);
        }

        [TestMethod]
        public void ABetterDynamicSizeContainer()
        {
            //ArrayList is a .Net 1.0 container. With .Net 2.0 generics were introduced and with it a new set of collections in
            //System.Collections.Generic The array like container is List<T>. List<T> (read "list of T") is a generic class. 
            //The "T" in the definition of List<T> is the type argument. You cannot declare an instace of List<T> without also
            //supplying a type in place of T.
            var list = new List<int>();
            Assert.AreEqual(FILL_ME_IN, list.Count);

            list.Add(42);
            Assert.AreEqual(FILL_ME_IN, list.Count);

            //Now just like int[], you can have a type safe dynamic sized container
            //list.Add("fourty two"); //<--Unlike ArrayList this is illegal.

            //List<T> also solves the boxing/unboxing issues of ArrayList. Unfortunately, you'll have to take Microsoft's word for it
            //as I can't find a way to prove it without some ugly MSIL beyond the scope of these Koans.
        }
        public class Widget
        {
        }

        [TestMethod]
        public void ListWorksWithAnyType()
        {
            //Just as with Array, list will work with any type
            List<Widget> list = new List<Widget>();
            list.Add(new Widget());
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void InitializingWithValues()
        {
            //Like array you can create a list with an initial set of values easily
            var list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void AddMultipleItems()
        {
            //You can add multiple items to a list at once
            List<int> list = new List<int>();
            list.AddRange(new[] { 1, 2, 3 });
            Assert.AreEqual(FILL_ME_IN, list.Count);
        }

        [TestMethod]
        public void RandomAccess()
        {
            //Just as with array, you can use the subscript notation to access any element in a list.
            List<int> list = new List<int> { 5, 6, 7 };
            Assert.AreEqual(FILL_ME_IN, list[2]);
        }

        //Do we need to rewrite this test?

        //[TestMethod]
        //public void BeyondTheLimits()
        //{
        //    List<int> list = new List<int> { 1, 2, 3 };
        //    //You cannot attempt to get data that doesn't exist
        //    Assert.Throws(typeof(FillMeIn), delegate () { int x = list[3]; });
        //}

        [TestMethod]
        public void ConvertingToFixedSize()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(FILL_ME_IN, list.ToArray());
        }

        [TestMethod]
        public void InsertingInTheMiddle()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            list.Insert(1, 6);
            Assert.AreEqual(FILL_ME_IN, list.ToArray());
        }

        [TestMethod]
        public void RemovingItems()
        {
            List<int> list = new List<int> { 2, 1, 2, 3 };
            list.Remove(2);
            Assert.AreEqual(FILL_ME_IN, list.ToArray());
        }

    }
}
