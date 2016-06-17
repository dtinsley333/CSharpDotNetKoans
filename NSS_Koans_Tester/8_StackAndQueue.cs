using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class StackAndQueue : Koan
    {
        

        [TestMethod]
        public void Boxing()
        {
            short s = 5;
            object os = s;
            Assert.AreEqual(s.GetType(), os.GetType());
            Assert.AreEqual(s, os);

            //While this it is true that everything is an object and all the above passes. Not everything is quite as it seems.
            //Under the covers .Net allocates memory for all value type objects (int, double, bool,...) on the stack. This is 
            //considerably more efficient than a heap allocation. .Net also has the ability to put a value type onto the heap.
            //(for calling methods and other reasons). The process of putting stack data into the heap is called "boxing" the 
            //process of taking the value type off the heap is called "unboxing". We won't go into the details (see Jeffrey 
            //Richter's book if you want details). This subject comes up because every time you put a value type into an 
            //ArrayList it must be boxed. Every time you read it from the ArrayList it must be unboxed. This can be a significat
            //cost.
        }

        [TestMethod]
        public void StackPushPop()
        {
            var stack = new Stack<int>();
            Assert.AreEqual(FILL_ME_IN, stack.Count);

            stack.Push(42);
            Assert.AreEqual(FILL_ME_IN, stack.Count);

            int x = stack.Pop();
            Assert.AreEqual(FILL_ME_IN, x);

            Assert.AreEqual(FILL_ME_IN, stack.Count);
        }

        [TestMethod]
        public void StackOrder()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(FILL_ME_IN, stack.ToArray());
        }

        [TestMethod]
        public void PeekingIntoAQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            Assert.AreEqual(FILL_ME_IN, queue.Peek());
            queue.Enqueue("two");
            Assert.AreEqual(FILL_ME_IN, queue.Peek());
        }

        [TestMethod]
        public void RemovingItemsFromTheQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            Assert.AreEqual(FILL_ME_IN, queue.Dequeue());
            Assert.AreEqual(FILL_ME_IN, queue.Count);
        }

        

    }  

}
