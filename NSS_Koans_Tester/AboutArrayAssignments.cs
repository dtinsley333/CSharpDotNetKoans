using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class AboutArrayAssignments :Koan
    {
        [TestMethod]
        public void AboutArrayAssignmentsImplicitAssignments()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var name = "John";
            Assert.AreEqual(typeof(FillMeIn), name.GetType());

            //but only if it can. So this doesn't work
            //var array = null;

            //It also knows the type, so once the above is in place, this doesn't work:
            //name = 42;
        }

        [TestMethod]
        public void AboutArrayAssignmentsImplicitArrayAssignmentWithSameTypes()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var names = new[] { "John", "Smith" };
            Assert.AreEqual(typeof(FillMeIn), names.GetType());

            //but only if it can. So this doesn't work
            //var array = new[] { "John", 1 };
        }

        [TestMethod]
        public void AboutArrayAssignmentsMultipleAssignmentsOnSingleLine()
        {
            //You can do multiple assignments on one line, but you 
            //still have to be explicit
            string firstName = "John", lastName = "Smith";
            Assert.AreEqual(FILL_ME_IN, firstName);
            Assert.AreEqual(FILL_ME_IN, lastName);
        }
    }
}
