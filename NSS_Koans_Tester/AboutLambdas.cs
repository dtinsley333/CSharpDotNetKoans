using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class AboutLambdas : Koan
    {
        [TestMethod]
        public void AboutLambdasUsingAnonymousMethods()
        {
           
            var numbers = new[] { 1, 2, 3, 4 };
            var result = Array.ConvertAll(numbers, delegate (int x)
            {
                return x.ToString();
            });

            Assert.AreEqual(FILL_ME_IN, result);
        }

        [TestMethod]
        public void AboutLambdasAnonymousMethodsCanAccessOuterVariables()
        {
            //Anonymous methods can access variable defined in the scope of the method where they are defined.
            //In C# this is called accessing an Outer Variable. In other languages it is called closure. 
            var numbers = new[] { 4, 5, 6, 7, 8, 9 };
            int toFind = 7;
            Assert.AreEqual(FILL_ME_IN, Array.FindIndex(numbers, delegate (int x)
            {
                return x == toFind;
            }));
        }

        [TestMethod]
        public void AboutLambdasAccessEvenAfterVariableIsOutOfScope()
        {
            Predicate<int> criteria;
            {
                //Anonymous methods even have access to the value after the value has gone out of scope
                int toFind = 7;
                criteria = delegate (int x)
                {
                    return x == toFind;
                };
            }
            var numbers = new[] { 4, 5, 6, 7, 8, 9 };
            //toFind is not available here, yet criteria still works
            Assert.AreEqual(FILL_ME_IN, Array.FindIndex(numbers, criteria));
        }

        [TestMethod]
        public void AboutLambdasLambdaExpressionsAreShorthand()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var anonymous = Array.ConvertAll(numbers, delegate (int x)
            {
                return x.ToString();
            });
            //Lambda expressions are really nothing more than a short hand way of writing anonymous methods
            //The following is the same work done using a Lambda expression. 
            //The delegate key word is replaced with => on the other side of the parameters
            //        |                               |
            //        |                               |-----|
            //        |----------------------------|        |
            //                                    \|/      \|/
            var lambda = Array.ConvertAll(numbers, (int x) =>
            {
                return x.ToString();
            });
            Assert.AreEqual(FILL_ME_IN, anonymous);
            //The => pair is spoken as "going into". If you were talking about this 
            //code with a peer, you would say "x going into..."
        }

        [TestMethod]
        public void AboutLambdasTypeCanBeInferred()
        {
            //Fortunately the above form of a Lambda is the most verbose form. 
            //Most of the time you can take many of the pieces out. 
            //The next few Koans will step you through the optional pieces.
            var numbers = new[] { 1, 2, 3, 4 };
            var anonymous = Array.ConvertAll(numbers, delegate (int x)
            {
                return x.ToString();
            });
            var lambda = Array.ConvertAll(numbers, (x) =>
            // type is removed from the parameter --^
            {
                return x.ToString();
            });
            Assert.AreEqual(FILL_ME_IN, anonymous);
        }

        [TestMethod]
        public void AboutLambdasParensNotNeededOnSingleParemeterLambdas()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var anonymous = Array.ConvertAll(numbers, delegate (int x)
            {
                return x.ToString();
            });
            var lambda = Array.ConvertAll(numbers, x =>
            //                                     ^-----------------------|
            //When you have only one parameter, no parenthesis are needed -|
            {
                return x.ToString();
            });
            Assert.AreEqual(FILL_ME_IN, anonymous);
        }

        [TestMethod]
        public void AboutLambdasBlockNotNeededOnSingleStatementLambdas()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var anonymous = Array.ConvertAll(numbers, delegate (int x)
            {
                return x.ToString();
            });
            var lambda = Array.ConvertAll(numbers, x => x.ToString());
            //When you have only one statement, the curly brackets are not needed. What other two things are also missing?
            Assert.AreEqual(FILL_ME_IN, anonymous);
        }

    }
}
