using System;
using Xunit;
using NSS_Koans;
using System.Collections.Generic;

namespace NSS_Koans_Tester
{
    public class Types
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
       
        [Fact]
        public void AboutTypesThisIsAString()
        {
            string str = "This is a string!";
            Assert.Equal(typeof(FillMeIn), str.GetType());
            //take note of the syntax on both sides of the assert
        }

        [Fact]
        public void AboutTypesTypeString()
        {
            string aString = "Nashville Software School";
            Assert.Equal(FILL_ME_IN, aString);
        }

        [Fact]
        public void AboutTypesThisIsABool()
        {
            bool boo = true;
            bool booo = false;
            Assert.True(booo);
            Assert.False(boo);
        }

        [Fact]
        public void AboutTypesABoolCanBeChanged()
        {
            bool nss1 = true;
            bool nss2 = false;

            string str1 = "NSS";
            string str2 = "Nashville Software School!";

            if (str1 != "Nashville Software School!")
            {
                nss1 = false;
            }

            if (str2 == "Nashville Software School!")
            {
                nss2 = true;
            }

           
            Assert.Equal(true, nss1);
            Assert.Equal(false,nss2);
        }

        [Fact]
        public void AboutTypesCharIsAType()
        {
            char letter = 'a';
            Assert.Equal(typeof(FillMeIn), letter.GetType());
            //What happens if you try to use double quotes??
        }

        [Fact]
        public void AboutTypesCharList()
        {
            List<char> myListOfChars = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Assert.Equal(FILL_ME_IN, myListOfChars[3]);
        }

        [Fact]
        public void AboutTypesCharsHaveIntValues()
        {
            int myChar = 'k';
            Assert.Equal(FILL_ME_IN, myChar);

            //Change the letter and see that each key has a value
        }

        [Fact]
        public void AboutTypesCharCanConvertToString()
        {
            char myChar = 'L';
            var myStr = myChar.ToString();
            Assert.Equal(typeof(FillMeIn), myStr.GetType());
        }

        [Fact]
        public void AboutTypesDoublesAreATypeOfNumber()
        {
            double number = 1.00794;
            Assert.Equal(typeof(FillMeIn), number.GetType());
        }


        [Fact]
        public void AboutTypesDecimalsHaveMorePrecisionButCanBeSlower()
        {
            decimal number = 1.1700m; // for a numeric real literal to be treated as decimal, use the suffix m or M
            Assert.Equal(typeof(FillMeIn), number.GetType());
        }

        [Fact]
        public void AboutTypesDecimalsCanHaveTrailingZeros()
        {
            decimal number = 1.170000m; 
            number = number + 0.0001m;
            Assert.Equal(FILL_ME_IN, number);
        }
   
      
        [Fact]
        public void AboutTypesIntegersAreAType()
        {
            var number = 11;
            Assert.Equal(typeof(FillMeIn), number.GetType());

        }

        [Fact]
        public void AboutTypesIntegersCanBeNegative()
        {
            int number = -17;
            Assert.Equal(typeof(FillMeIn), number.GetType());

        }

        [Fact]
        public void AboutTypesCanDoMathWithIntegers()
        {
            int number1 = 2;
            int number2 = 5;
            int number3 = (2 * number2) / (12 - number1);
            Assert.Equal(FILL_ME_IN, number3);
        }


    }
}
