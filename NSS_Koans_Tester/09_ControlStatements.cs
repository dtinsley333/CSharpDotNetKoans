using System;
using Xunit;
using System.Collections.Generic;
using NSS_Koans;

namespace NSS_Koans_Tester
{

    public class ControlStatements
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutControlStatementsIfThenElseStatementsWithBrackets()
        {
            bool IsOfVotingAge;
            var age = 18;
            if (age>=18)
            {
                IsOfVotingAge = true;
            }
            else
            {
                IsOfVotingAge=false;
            }

            Assert.Equal(FILL_ME_IN, IsOfVotingAge);
        }

        [Fact]
        public void AboutControlStatementsIfThenElseStatementsWithoutBrackets()
        {
            bool IsOfVotingAge;
            var age = 18;
            if (age >= 18)
                IsOfVotingAge = true;
            else
                IsOfVotingAge = false;

            Assert.Equal(FILL_ME_IN, IsOfVotingAge);

        }


        [Fact]
        public void AboutControlStatementsIfThenStatementsWithoutBrackets()
        {
            bool b = false;
            if (true)
                b = true;

            Assert.Equal(FILL_ME_IN, b);
        }

        [Fact]
        public void AboutControlStatementsWhyItsWiseToAlwaysUseBrackets()
        {
            bool b1 = false;
            bool b2 = false;

            int counter = 1;

            if (counter == 0)
                b1 = true;
            b2 = true;

            Assert.Equal(FILL_ME_IN, b1);
            Assert.Equal(FILL_ME_IN, b2);
        }

        [Fact]
        public void AboutControlStatementsTernaryOperators()
        {
            Assert.Equal(FILL_ME_IN, (true ? 1 : 0));
            Assert.Equal(FILL_ME_IN, (false ? 1 : 0));
        }

      

        [Fact]
        public void AboutControlStatementsAssignIfNullOperator()
        {
            int? nullableInt = null;

            int x = nullableInt ?? 42;

            Assert.Equal(FILL_ME_IN, x);

        }

        [Fact]
        public void AboutControlStatementsIsOperators()
        {
            //The default value of booleans is false
            bool isKoan=false;
            bool isAboutControlStatements=false;
            bool isAboutMethods=false;

            var myType = new Koan();

            if (myType is Koan)
            {
                isKoan = true;
            }


            if (myType is ControlStatements)
            {
                isAboutControlStatements = true;
            }

            if (myType is Methods)
            {
                isAboutMethods = true;
            }

            Assert.Equal(FILL_ME_IN, isKoan);
            Assert.Equal(FILL_ME_IN, isAboutControlStatements);
            Assert.Equal(FILL_ME_IN, isAboutMethods);

        }
        [Fact]
        public void AboutControlStatementsWhileStatement()
        {
            int i = 1;
            int result = 1;
            while (i <= 3)
            {
                result = result + i;
                i += 1;
            }
            Assert.Equal(FILL_ME_IN, result);
        }
        [Fact]
        public void AboutControlStatementsBreakStatement()
        {
            int i = 1;
            int result = 1;
            while (true)
            {
                if (i > 3) { break; }
                result = result + i;
                i += 1;
            }
            Assert.Equal(FILL_ME_IN, result);
        }
        [Fact]
        public void AboutControlStatementsContinueStatement()
        {
            int i = 0;
            var result = new List<int>();
            while (i < 10)
            {
                i += 1;
                if ((i % 2) == 0) { continue; }
                result.Add(i);
            }
            Assert.Equal(FILL_ME_IN, result);
        }
        [Fact]
        public void AboutControlStatementsForStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (list[i].ToUpper());
            }
            Assert.Equal(FILL_ME_IN, list);
        }
        [Fact]
        public void AboutControlStatementsForEachStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            var finalList = new List<string>();
            foreach (string item in list)
            {
                finalList.Add(item.ToUpper());
            }
            Assert.Equal(FILL_ME_IN, list);
            Assert.Equal(FILL_ME_IN, finalList);
        }
        [Fact]
        public void AboutControlStatementsModifyingACollectionDuringForEach()
        {
            var list = new List<string> { "fish", "and", "chips" };
            try
            {
                foreach (string item in list)
                {
                    list.Add(item.ToUpper());
                }
            }
            catch (Exception ex)
            {
                Assert.Equal(typeof(FillMeIn), ex.GetType());
            }
        }

        [Fact]
        public void AboutControlStatementsCatchingModificationExceptions()
        {
            string whoCaughtTheException = "No one";

            var list = new List<string> { "fish", "and", "chips" };
            try
            {
                foreach (string item in list)
                {
                    try
                    {
                        list.Add(item.ToUpper());
                    }
                    catch
                    {
                        whoCaughtTheException = "When we tried to Add it";
                    }
                }
            }
            catch
            {
                whoCaughtTheException = "When we tried to move to the next item in the list";
            }

            Assert.Equal(FILL_ME_IN, whoCaughtTheException);
        }
    }
}
