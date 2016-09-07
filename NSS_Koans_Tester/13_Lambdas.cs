using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using NSS_Koans;

namespace NSS_Koans_Tester
{
    public class Person
    {
        public string FirstName { get; set; }
        public string City { get; set; }
    }


    public class Lambdas
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void LambdaExpression()
        {
            List<int> firstNumbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> secondNumbers = firstNumbers.Where(n => n % 2 == 1).ToList();

            Assert.Equal(FILL_ME_IN, secondNumbers);
        }

        [Fact]
        public void LambdasToIterateAList()
        {
            List<int> numbers = new List<int>() { 1, 55, 62, 42, 9, 18 };
            List<int> filteredNumbers = new List<int>();
            foreach (int i in numbers.Where(
                x =>
                {
                    if (x %2 != 0)
                        return true;
                    else return false;
                }

                    ))
                filteredNumbers.Add(i);

            Assert.Equal(FILL_ME_IN, filteredNumbers);

        }

        [Fact]
        public void LambdaWithAForEach()
        {
            List<int> source = new List<int>() { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };
            List<int> final = new List<int>();
            foreach (int i in source.Where(
                     x =>
                     {
                         if (x <= 3)
                             return true;
                         else if (x >= 7)
                             return true;
                         return false;
                     }

                    ))
                final.Add(i);
            
            Assert.Equal(FILL_ME_IN, final);

        }
        [Fact]
        public void ExpressionLambdasAdd()
        {
            Func<int, int> plusOne = x => { return x + 1; };
            Assert.Equal(FILL_ME_IN, plusOne(1));

        }

        [Fact]
        public void ExpressionLambdasMultiply()
        {
            Func<int, int, int> multiply = ( x, y) => { return x * y; };
            Assert.Equal(FILL_ME_IN, multiply(3,2));
        }

        [Fact]
        public void LambdasWithQueryOperators()
        {
            Func<int, bool> lambdaFunction = x => x == 11;

            bool trueResult = lambdaFunction(-1);//replace with number that works
            bool falseResult = lambdaFunction(-1);//replace with a number that works

            Assert.True(trueResult);
            Assert.False(falseResult);
        }

        [Fact]
        public void CanQueryDataWithLambdas()
        {
            List<Person> People = new List<Person>() {
                new Person { FirstName = "Jim", City = "Nashville"},
                new Person { FirstName = "Kim", City = "Atlanta" },
                new Person { FirstName = "Bob", City = "New York" },
                new Person { FirstName = "Sara", City = "Nashville" }
            };

            List<Person> query = People.Where(p => p.City == "Nashville").ToList();

            Assert.Equal(FILL_ME_IN, query[0].FirstName);
        }

    }
}
