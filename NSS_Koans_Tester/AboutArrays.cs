using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSS_Koans;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class AboutArrays : Koan
    {
        [TestMethod]
        public void AboutArraysCreatingArrays()
        {
            var empty_array = new object[] { };
            Assert.AreEqual(typeof(System.Object[]), empty_array.GetType());
            //Note that you have to explicitly check for subclasses
            Assert.IsTrue(typeof(System.Object[]).IsAssignableFrom(empty_array.GetType()));
            Assert.AreEqual(FILL_ME_IN, empty_array.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(FillMeIn))]
        public void AboutArraysArrayLiterals()
        {
            //You don't have to specify a type if the arguments can be inferred
            var array = new[] { 42 };
            Assert.AreEqual(typeof(int[]), array.GetType());
            Assert.AreEqual(new int[] { 42 }, array);
        }

        [TestMethod]
        public void AboutArraysAreArrays0or1Based()
        {
            var array = new[] { 42 };
            Assert.AreEqual(42, array[((int)FILL_ME_IN)]);
            //This is important because...
            Assert.IsTrue(array.IsFixedSize);
            //This is because the array is fixed at length 1. You could write a function
        }

        [TestMethod]
        public void AboutArraysLists()
        {
            //which created a new array bigger than the last, copied the elements over, and
            //returned the new array. Or you could do this:
            var array = new[] { 42 };
            List<int> dynamicArray = new List<int>();
            dynamicArray.Add(42);
            Assert.AreEqual(array, dynamicArray.ToArray());

            dynamicArray.Add(13);
            Assert.AreEqual((new int[] { 42, (int)FILL_ME_IN }), dynamicArray.ToArray());
        }

        [TestMethod]
        public void AboutArraysAccessingArrayElements()
        {
            var array = new[] { "peanut", "butter", "and", "jelly" };

            Assert.AreEqual(FILL_ME_IN, array[0]);
            Assert.AreEqual(FILL_ME_IN, array[3]);

            //This doesn't work: Assert.AreEqual(FILL_ME_IN, array[-1]);
        }

        [TestMethod]
        public void AboutArraysSlicingArrays()
        {
            var array = new[] { "peanut", "butter", "and", "jelly" };

            Assert.AreEqual(new string[] { (string)FILL_ME_IN, (string)FILL_ME_IN }, array.Take(2).ToArray());
            Assert.AreEqual(new string[] { (string)FILL_ME_IN, (string)FILL_ME_IN }, array.Skip(1).Take(2).ToArray());
        }

        [TestMethod]
        public void AboutArraysPushingAndPopping()
        {
            var array = new[] { 1, 2 };
            Stack stack = new Stack(array);
            stack.Push("last");
            Assert.AreEqual(FILL_ME_IN, stack.ToArray());
            var poppedValue = stack.Pop();
            Assert.AreEqual(FILL_ME_IN, poppedValue);
            Assert.AreEqual(FILL_ME_IN, stack.ToArray());
        }

        [TestMethod]
        public void AboutArraysShifting()
        {
            //Shift == Remove First Element
            //Unshift == Insert Element at Beginning
            //C# doesn't provide this natively. You have a couple
            //of options, but we'll use the LinkedList<T> to implement
            var array = new[] { "Hello", "World" };
            var list = new LinkedList<string>(array);

            list.AddFirst("Say");
            Assert.AreEqual(FILL_ME_IN, list.ToArray());

            list.RemoveLast();
            Assert.AreEqual(FILL_ME_IN, list.ToArray());

            list.RemoveFirst();
            Assert.AreEqual(FILL_ME_IN, list.ToArray());

            list.AddAfter(list.Find("Hello"), "World");
            Assert.AreEqual(FILL_ME_IN, list.ToArray());
        }

    }
}
