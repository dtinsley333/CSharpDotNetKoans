using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSS_Koans;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class UnitTest1 : Koan
    {
        [TestMethod]
        public void CreatingArrays()
        {
            var empty_array = new object[] { };
            Assert.AreEqual(typeof(System.Object[]), empty_array.GetType());
            //Note that you have to explicitly check for subclasses
            Assert.IsTrue(typeof(System.Object[]).IsAssignableFrom(empty_array.GetType()));
            Assert.AreEqual(FILL_ME_IN, empty_array.Length);
        }
    }
}
