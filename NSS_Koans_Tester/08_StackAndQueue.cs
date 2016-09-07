﻿using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using NSS_Koans;


namespace NSS_Koans_Tester
{

    public class StackAndQueue
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;

        [Fact]
        public void AboutStackandQueueBoxing()
        {
            short s = 5;
            object os = s;
            Assert.Equal(s.GetType(), os.GetType());
            Assert.Equal(FILL_ME_IN, os);

            //While it is true that everything is an object and all the above passes. Not everything is quite as it seems.
            //Under the covers .Net allocates memory for all value type objects (int, double, bool,...) on the stack. This is 
            //considerably more efficient than a heap allocation. .Net also has the ability to put a value type onto the heap.
            //(for calling methods and other reasons). The process of putting stack data into the heap is called "boxing" the 
            //process of taking the value type off the heap is called "unboxing". We won't go into the details (see Jeffrey 
            //Richter's book if you want details). This subject comes up because every time you put a value type into an 
            //ArrayList it must be boxed. Every time you read it from the ArrayList it must be unboxed. This can be a significant cost.
        }

        [Fact]
        public void AboutStackandQueueStackPushPop()
        {
            var stack = new Stack<int>();
            Assert.Equal(FILL_ME_IN, stack.Count);

            stack.Push(42);
            Assert.Equal(FILL_ME_IN, stack.Count);

            int x = stack.Pop();
            Assert.Equal(FILL_ME_IN, x);

            Assert.Equal(FILL_ME_IN, stack.Count);
        }

        [Fact]
        //Hint: Look back at the array tests around line 75
        public void AboutStackandQueueStackOrder()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Equal(FILL_ME_IN, stack.ToArray());
        }

        [Fact]
        public void AboutStackandQueuePeekingIntoAQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            Assert.Equal(FILL_ME_IN, queue.Peek());
            queue.Enqueue("two");
            Assert.Equal(FILL_ME_IN, queue.Peek());
        }

        [Fact]
        public void AboutStackandQueueRemovingItemsFromTheQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            Assert.Equal(FILL_ME_IN, queue.Dequeue());
            Assert.Equal(FILL_ME_IN, queue.Count);
        }

        //A good way to remember the differnece between a stack and a queue is that a queue is like
        //standing in line, first one in line is the first one out. A stack is like a stack of
        //cafeteria trays, the first one put on the stack is the last one out

    }  

}
