using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class Null : Koan
    {
        [TestMethod]
        public void AboutNullNullIsNotAnObject()
        {
            Assert.IsTrue(typeof(object).IsAssignableFrom(null)); //not everything is an object
        }

        [TestMethod]
        public void AboutNullCheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.IsTrue(obj == FILL_ME_IN);
        }

        [TestMethod]
        public void AboutNullABetterWayToCheckThatAnObjectIsNull()
            //Use this method to test if an objecct is null
        {
            object obj = null;
            Assert.IsNull(FILL_ME_IN);
        }

        [TestMethod]
        public void AboutNullAWayNotToCheckThatAnObjectIsNull()
            //Don't do this
        {
            object obj = null;
            Assert.IsTrue(obj == FILL_ME_IN);
        }

    }
}
