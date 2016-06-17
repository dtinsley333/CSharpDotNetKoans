using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NSS_Koans_Tester
{
    [TestClass]
    public class Types : Koan
    {
        [TestMethod]
        public void ThisIsAString()
        {
            string str = "This is a string!";
            Assert.AreEqual(typeof(FillMeIn), str.GetType());
        }

        [TestMethod]
        public void TypeString()
        {
            string aString = "Nashville Software School";
            Assert.AreEqual(FILL_ME_IN, aString);
        }

        [TestMethod]
        public void ThisIsABool()
        {
            bool boo = true;
            bool booo = false;
            Assert.IsTrue(FillIn);
            Assert.IsFalse(FillIn);
        }

        [TestMethod]
        public void ABoolCanBeChanged()
        {
            bool nss1 = true;
            bool nss2 = false;

            string str1 = "NSS";
            string str2 = "Nashville Software School!";

            if (str1 != "Nashville Software School!")
            { nss1 = false; }

            if (str2 == "Nashville Software School!") { nss2 = true; }

            Assert.IsFalse(FillIn);
            Assert.IsTrue(FillIn);
        }

        [TestMethod]
        public void CharIsAType()
        {
            char letter = 'a';
            Assert.AreEqual(typeof(FillMeIn), letter.GetType());
        }

        [TestMethod]
        public void CharList()
        {
            List<char> myChar = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Assert.AreEqual(FILL_ME_IN, myChar[3]);
        }

        [TestMethod]
        public void CharsHaveIntValues()
        {
            int myChar = 'k';
            Assert.AreEqual(FILL_ME_IN, myChar);

            //Change the letter and see that each key has a value
        }

        [TestMethod]
        public void CharCanConvertToString()
        {
            char myChar = 'L';
            var myStr = myChar.ToString();
            Assert.AreEqual(typeof(FillMeIn), myStr.GetType());
        }

        [TestMethod]
        public void DoublesAreATypeOfNumber()
        {
            double number = 1.00794;
            Assert.AreEqual(typeof(FillMeIn), number.GetType());
        }


        [TestMethod]
        public void DecimalsHaveMorePrecisionButCanBeSlower()
        {
            decimal number = 1.1700m; // for a numeric real literal to be treated as decimal, use the suffix m or M
            Assert.AreEqual(typeof(FillMeIn), number.GetType());
        }

        [TestMethod]
        public void DecimalsCanHaveTrailingZeros()
        {
            decimal number = 1.170000m; 
            number = number + 0.0001m;
            Assert.AreEqual(FILL_ME_IN, number);
        }
   
      
        [TestMethod]
        public void IntegersAreAType()
        {
            var number = 11;
            Assert.AreEqual(typeof(FillMeIn), number.GetType());

        }

        [TestMethod]
        public void IntegersCanBeNegative()
        {
            int number = -17;
            Assert.AreEqual(typeof(FillMeIn), number.GetType());

        }

        [TestMethod]
        public void CanDoMathWithIntegers()
        {
            int number1 = 2;
            int number2 = 5;
            int number3 = (2 * number2) / (12 - number1);
            Assert.AreEqual(FILL_ME_IN, number3);
        }


    }
}
