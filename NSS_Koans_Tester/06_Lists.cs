
using Xunit;
using System.Collections.Generic;
using System.Text;
using NSS_Koans;


namespace NSS_Koans_Tester
{
   
    public class Lists
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutListsListsAreTyped()
        {
            List<int> integers = new List<int>();
            List<string> names = new List<string>();
            Assert.Equal("The test below is going to pass as is",
                "but go ahead an fix it so it makes sense");//then comment this test out =-)
            Assert.IsType<List<int>>(names);
            Assert.IsType<List<string>>(integers);
        }

        [Fact]
        public void AboutListsOneWayToCreateAList()
        {
            List<char> characterList = new List<char>() { 'a', 'b', 'c' };
            Assert.Equal(FILL_ME_IN, characterList[0]);
            Assert.Equal(FILL_ME_IN, characterList[1]);
            Assert.Equal(FILL_ME_IN, characterList[2]);

        }

        [Fact]
        public void AboutListsAnotherWayToCreateAList()
        {
            List<char> characterList = new List<char>();
            characterList.Add('a');
            characterList.Add('b');
            characterList.Add('c');

            Assert.Equal(FILL_ME_IN, characterList[0]);
            Assert.Equal(FILL_ME_IN, characterList[1]);
            Assert.Equal(FILL_ME_IN, characterList[2]);
        }

        [Fact]
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

            Assert.Equal(FILL_ME_IN, theLatestInteger);
        }

        [Fact]
        public void AboutListsCanGetTheNumberOfItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.Equal(FILL_ME_IN, stringList.Count);
        }

        [Fact]
        public void AboutListsCanRemoveAllItemsInAList()
        {
            List<string> stringList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            Assert.Equal(FILL_ME_IN, stringList.Count);
            stringList.Clear();
            Assert.Equal(FILL_ME_IN, stringList.Count);

        }

        [Fact]
        public void AboutListsCanCheckToSeeWhatAListContains()
        {
            List<string> fruitList = new List<string>() { "apple", "banana", "strawberry", "peach", "watermelon" };
            bool bananasInStock = fruitList.Contains("banana");
            bool grapesInStock = fruitList.Contains("grapes");
            Assert.True(grapesInStock);
            Assert.False(bananasInStock);
        }

        [Fact]
        public void AboutListsListsCanBeConvertedToStringsWithStringBuilder()
        {
            List<string> nss = new List<string>() { "nashville", "software", "school"};
            StringBuilder builder = new StringBuilder();
            foreach (string word in nss)
            {
                builder.Append(word).Append(" ");
            }
            string result = builder.ToString();

            Assert.Equal(FILL_ME_IN, result);
            
        }

        [Fact]
        public void AboutListsListsCanBeConvertedToStringsWithJoin()
        {
            List<string> dogs = new List<string>();
            dogs.Add("Aigi");
            dogs.Add("Spitz");
            dogs.Add("Mastiff"); 
            dogs.Add("Finnish Spitz"); 
            dogs.Add("Briard"); 

            string dogString = string.Join(", ", dogs.ToArray());
            Assert.Equal(FILL_ME_IN, dogString);
        }

        [Fact]
        public void AboutListsABetterDynamicSizeContainer()
        {
            //The "T" in the definition of List<T> is the type argument. You cannot declare an instace of List<T> without also
            //supplying a type in place of T.
            var list = new List<int>();
            Assert.Equal(FILL_ME_IN, list.Count);

            list.Add(42);
            Assert.Equal(FILL_ME_IN, list.Count);

            //Now just like int[], you can have a type safe dynamic sized container
            //list.Add("fourty two"); //<--Unlike ArrayList this is illegal.

            //List<T> also solves the boxing/unboxing issues of ArrayList. Check out the Arrays test class around line 127 if you've already forgotten about arraylists.
        }
        public class Widget
        {
            //yup, we just totally created our own type in the middle of this test class ;-)
        }

        [Fact]
        public void AboutListsListWorksWithAnyType()
        {
            //Just as with Array, list will work with any type
            List<Widget> list = new List<Widget>();
            list.Add(new Widget());
            Assert.Equal(FILL_ME_IN, list.Count);
        }

        [Fact]
        public void AboutListsInitializingWithValues()
        {
            //Like array you can create a list with an initial set of values easily
            var list = new List<int> { 1, 2, 3 };
            Assert.Equal(FILL_ME_IN, list.Count);
        }

        [Fact]
        public void AboutListsAddMultipleItems()
        {
            //You can add multiple items to a list at once
            List<int> list = new List<int>();
            list.AddRange(new[] { 1, 2, 3 });
            Assert.Equal(FILL_ME_IN, list.Count);
        }

        [Fact]
        public void AboutListsRandomAccess()
        {
            //Just as with array, you can use the subscript notation to access any element in a list.
            List<int> list = new List<int> { 5, 6, 7 };
            Assert.Equal(FILL_ME_IN, list[2]);
        }

        [Fact]
     
        public void AboutListsBeyondTheLimits()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            //You cannot attempt to get data that doesn't exist
            Assert.Equal(4, list[3]);
        }

        [Fact]
        public void AboutListsConvertingToFixedSize()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Assert.Equal(FILL_ME_IN, list.ToArray());
        }

        [Fact]
        public void AboutListsInsertingInTheMiddle()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            list.Insert(1, 6);
           Assert.Equal(FILL_ME_IN, list.ToArray());
        }

        [Fact]
        public void AboutListsRemovingItems()
        {
            List<int> list = new List<int> { 2, 1, 2, 3 };
            list.Remove(2);
            Assert.Equal(FILL_ME_IN, list.ToArray());
        }

    }
}
