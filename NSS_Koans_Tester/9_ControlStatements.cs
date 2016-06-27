using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class ControlStatements : Koan
    {
        [TestMethod]
        public void AboutControlStatementsIfThenElseStatementsWithBrackets()
        {
            bool b;
            if (true)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [TestMethod]
        public void AboutControlStatementsIfThenElseStatementsWithoutBrackets()
        {
            bool b;
            if (true)
                b = true;
            else
                b = false;

            Assert.AreEqual(FILL_ME_IN, b);

        }

        [TestMethod]
        public void AboutControlStatementsIfThenStatementsWithBrackets()
        {
            bool b = false;
            if (true)
            {
                b = true;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [TestMethod]
        public void AboutControlStatementsIfThenStatementsWithoutBrackets()
        {
            bool b = false;
            if (true)
                b = true;

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [TestMethod]
        public void AboutControlStatementsWhyItsWiseToAlwaysUseBrackets()
        {
            bool b1 = false;
            bool b2 = false;

            int counter = 1;

            if (counter == 0)
                b1 = true;
            b2 = true;

            Assert.AreEqual(FILL_ME_IN, b1);
            Assert.AreEqual(FILL_ME_IN, b2);
        }

        [TestMethod]
        public void AboutControlStatementsTernaryOperators()
        {
            Assert.AreEqual(FILL_ME_IN, (true ? 1 : 0));
            Assert.AreEqual(FILL_ME_IN, (false ? 1 : 0));
        }

        [TestMethod]
        public void AboutControlStatementsNullableTypes()
        {
            int i = 0;
            //i = null; //You can't do this

            int? nullableInt = null; //but you can do this
            Assert.IsNotNull(FILL_ME_IN);
            Assert.IsNull(FILL_ME_IN);
        }

        [TestMethod]
        public void AboutControlStatementsAssignIfNullOperator()
        {
            int? nullableInt = null;

            int x = nullableInt ?? 42;

            Assert.AreEqual(FILL_ME_IN, x);
        }

        [TestMethod]
        public void AboutControlStatementsIsOperators()
        {
            bool isKoan = false;
            bool isAboutControlStatements = false;
            bool isAboutMethods = false;

            var myType = this;

            if (myType is Koan)
                isKoan = true;


            if (myType is ControlStatements)
                isAboutControlStatements = true;

            if (myType is Methods)
                isAboutMethods = true;

            Assert.AreEqual(FILL_ME_IN, isKoan);
            Assert.AreEqual(FILL_ME_IN, isAboutControlStatements);
            Assert.AreEqual(FILL_ME_IN, isAboutMethods);

        }
        [TestMethod]
        public void AboutControlStatementsWhileStatement()
        {
            int i = 1;
            int result = 1;
            while (i <= 3)
            {
                result = result + i;
                i += 1;
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }
        [TestMethod]
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
            Assert.AreEqual(FILL_ME_IN, result);
        }
        [TestMethod]
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
            Assert.AreEqual(FILL_ME_IN, result);
        }
        [TestMethod]
        public void AboutControlStatementsForStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (list[i].ToUpper());
            }
            Assert.AreEqual(FILL_ME_IN, list);
        }
        [TestMethod]
        public void AboutControlStatementsForEachStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            var finalList = new List<string>();
            foreach (string item in list)
            {
                finalList.Add(item.ToUpper());
            }
            Assert.AreEqual(FILL_ME_IN, list);
            Assert.AreEqual(FILL_ME_IN, finalList);
        }
        [TestMethod]
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
                Assert.AreEqual(typeof(FillMeIn), ex.GetType());
            }
        }

        [TestMethod]
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

            Assert.AreEqual(FILL_ME_IN, whoCaughtTheException);
        }
    }
}
