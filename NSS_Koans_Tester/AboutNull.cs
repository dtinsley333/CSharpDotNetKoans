using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class AboutNull : Koan
    {
        [TestMethod]
        public void AboutNullNullIsNotAnObject()
        {
            Assert.IsTrue(typeof(object).IsAssignableFrom(null)); //not everything is an object
        }


        //Need to refactor this test or get rid of it

        [TestMethod]
        public void AboutNullYouGetNullPointerErrorsWhenCallingMethodsOnNil()
        {
            //What is the Exception that is thrown when you call a method on a null object?
            //Don't be confused by the code below. It is using Anonymous Delegates which we will
            //cover later on. 
            object nothing = null;
            //Assert.Throws(typeof(FillMeIn), delegate () { nothing.ToString(); });

            //What's the message of the exception? What substring or pattern could you test
            //against in order to have a good idea of what the string is?
            try
            {
                nothing.ToString();
            }
            catch (System.Exception ex)
            {
               // Assert.Contains(FILL_ME_IN as string, ex.Message);
            }
        }

        [TestMethod]
        public void AboutNullCheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.IsTrue(obj == FILL_ME_IN);
        }

        [TestMethod]
        public void AboutNullABetterWayToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.IsNull(FILL_ME_IN);
        }

        [TestMethod]
        public void AboutNullAWayNotToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.IsTrue(obj.Equals(null));
        }

    }
}
