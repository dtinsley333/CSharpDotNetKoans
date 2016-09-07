using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using NSS_Koans;


namespace NSS_Koans_Tester
{

    public class AboutArrays 
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutArraysCreatingArrays()
        {
            var empty_array = new object[] { };
            Assert.Equal(typeof(System.Object[]), empty_array.GetType());
            //Note that you have to explicitly check for subclasses
            Assert.True(typeof(System.Object[]).IsAssignableFrom(empty_array.GetType()));
            Assert.Equal(FILL_ME_IN, empty_array.Length);
        }

        [Fact]
        public void AboutArraysArrayLiterals()
        {
            //You don't have to specify a type if the arguments can be inferred, but it's always better to be explicit when you can be
            var array = new[] { 42 };
            
            Assert.Equal(typeof(int[]), array.GetType());
            Assert.Equal(new int[] { 12 }, array);
        }

        [Fact]
        public void AboutArraysAreArrays0or1Based()
        {
            var array = new[] { 42 };
            Assert.Equal(FILL_ME_IN, array[0]);
            //This is important because...
            //Assert.IsTrue(array.IsFixedSize);
        }

        [Fact]
        public void AboutArraysAddingItemsToAnArrayRequiresUseOfAnotherType()
        {
            //When you want to add an item to an array, you could write a function
            //to create a new array bigger than the last, copy the elements over, and
            //return the new array. Or you could do this:
            var array = new[] { 42 };
            List<int> dynamicArray = new List<int>();
            dynamicArray.Add(42);
            Assert.Equal(array, dynamicArray.ToArray());
            dynamicArray.Add(13);
            Assert.Equal((new int[] { 42, 0 }), dynamicArray.ToArray());
        }

        [Fact]
        public void AboutArraysAccessingArrayElements()
        {
            var array = new[] { "peanut", "butter", "and", "jelly" };

            Assert.Equal(FILL_ME_IN, array[0]);
            Assert.Equal(FILL_ME_IN, array[3]);

            //This doesn't work: Assert.Equal(FILL_ME_IN, array[-1]);
        }

        [Fact]
        public void AboutArraysSlicingArrays()
        {
            var array = new[] { "peanut", "butter", "and", "jelly" };

            Assert.Equal(new string[] { (string)FILL_ME_IN, (string)FILL_ME_IN }, array.Take(2).ToArray());
            Assert.Equal(new string[] { (string)FILL_ME_IN, (string)FILL_ME_IN }, array.Skip(1).Take(2).ToArray());
        }

        [Fact]
        public void AboutArraysPushingAndPopping()
        {
            var array = new[] { 1, 2 };
            Stack stack = new Stack(array);
            stack.Push(3);
            //what numbers are in the stack?
            Assert.Equal(FILL_ME_IN, stack.ToArray());
            //what order are the numbers in?
            Assert.Equal(FILL_ME_IN, stack.ToArray());
            var poppedValue = stack.Pop();
            Assert.Equal(FILL_ME_IN, poppedValue);
            Assert.Equal(FILL_ME_IN, stack.ToArray());
        }

        [Fact]
        public void AboutArraysShifting()
        {
            //Shift == Remove First Element
            //Unshift == Insert Element at Beginning
            //C# doesn't provide this natively. You have a couple
            //of options, but we'll use the LinkedList<T> to implement
            var array = new[] { "Hello", "World" };
            var list = new LinkedList<string>(array);

            list.AddFirst("Say");
            Assert.Equal(new string[] { "Say", "Hello", "World" }, list.ToArray());

            list.RemoveLast();
            Assert.Equal(FILL_ME_IN, list.ToArray());

            list.RemoveFirst();
            Assert.Equal(FILL_ME_IN, list.ToArray());

            list.AddAfter(list.Find("Hello"), "World");
            Assert.Equal(FILL_ME_IN, list.ToArray());
        }

        [Fact]
        public void AboutArraysArrayListSizeIsDynamic()
        {
            //When you worked with Array, the fact that Array is fixed size was mentioned.
            //The size of an array cannot be changed after you allocate it. To get around that
            //you need a class from the System.Collections namespace such as ArrayList
            ArrayList list = new ArrayList();
            Assert.Equal(FILL_ME_IN, list.Count);

            list.Add(42);
            Assert.Equal(FILL_ME_IN, list.Count);
        }

        [Fact]
        public void AboutArraysArrayListHoldsObjects()
        {
            ArrayList list = new ArrayList();
            list.Add("one"); //We added a string
            list.Add(2); //We can also add an int
            System.Reflection.MethodInfo method = list.GetType().GetMethod("Add");
            Assert.Equal(typeof(FillMeIn), method.GetParameters()[0].ParameterType);
        }

        [Fact]
        public void AboutArraysMustCastWhenRetrieving()
        {
            //There are a few problems with ArrayList holding object references. The first 
            //is that you must cast the items you fetch back to the original type.
            ArrayList list = new ArrayList();
            list.Add(42);
            int x = 0;
            //x = (int)list[0];
            Assert.Equal(x, 42);
        }

        [Fact]
        public void AboutArraysArrayListIsNotStronglyTyped()
        {
            //Having to cast everywhere is tedious. But there is also another issue lurking
            //ArrayList can hold more than one type. 
            ArrayList list = new ArrayList();
            list.Add(42);
            list.Add("fourty two");
            Assert.Equal(FILL_ME_IN, list[0]);
            Assert.Equal(FILL_ME_IN, list[1]);

            //While there are a few cases where it could be nice, instead what it means is that 
            //anytime your code works with an array list you have to check that the element is 
            //of the type you expect.
        }

        [Fact]
        public void AboutArrayAssignmentsImplicitAssignments()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var name = "John";
            Assert.Equal(typeof(FillMeIn), name.GetType());

            //but only if it can. So this doesn't work
            //var array = null;

            //It also knows the type, so once the above is in place, this doesn't work:
            //name = 42;
        }

        [Fact]
        public void AboutArrayAssignmentsImplicitArrayAssignmentWithSameTypes()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var names = new[] { "John", "Smith" };
            Assert.Equal(typeof(FillMeIn), names.GetType());

            //but only if it can. So this doesn't work
            //var array = new[] { "John", 1 };
        }

        [Fact]
        public void AboutArrayAssignmentsMultipleAssignmentsOnSingleLine()
        {
            //You can do multiple assignments on one line, but you 
            //still have to be explicit
            string firstName = "John", lastName = "Smith";
            Assert.Equal(FILL_ME_IN, firstName);
            Assert.Equal(FILL_ME_IN, lastName);
        }

    }
}
