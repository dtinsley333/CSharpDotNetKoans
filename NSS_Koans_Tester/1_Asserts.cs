using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class Asserts : Koan
    {
        [TestMethod]
        public void AboutAssertsAssertTruth()
        {
            Assert.IsTrue(FillIn); //This should be true
        }

        [TestMethod]
        public void AboutAssertsAssertTruthWithMessage()
        {
            Assert.IsTrue(FillIn, "change this message to anything you'd like");
        }

        [TestMethod]
        public void AboutAssertsAssertEquality()
        {
            var expectedValue = 3; //change this line
            var actualValue = 1 + 1;
            Assert.IsTrue(expectedValue == actualValue);
        }

        [TestMethod]
        public void AboutAssertsABetterWayOfAssertingEquality()
        {
            var expectedValue = 3; //change this line
            var actualValue = 1 + 1;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void AboutAssertsFillInValues()
        {
            Assert.AreEqual(FILL_ME_IN, 1 + 1);
        }

    }
}
