using System;
using Xunit;
using NSS_Koans;

namespace NSS_Koans_Tester
{


    public class Asserts
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;

        [Fact]
        public void TheObjectShouldNotBeNull()
        {
            Object duck = new object(); //Object is the base of all objects
            Assert.NotNull(duck); //This should be true
        }

        [Fact]
        public void IsTheDataTypeADecimal()
        {
            string milesPerGallon = "30.5";
            Assert.IsType(typeof(decimal), milesPerGallon);
        }

        [Fact]
        public void ObjectsShouldBeEqual()
        {
            var expectedValue = 3; //change this line
            var actualValue = 1 + 1;
            Assert.True(expectedValue == actualValue);
        }

        [Fact]
        public void ABetterWayOfAssertingEquality()
        {
            var expectedValue = 3; //change this line
            var actualValue = 1 + 1;
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void AboutAssertsFillInValues()
        {
            Assert.Equal(Koan.FILL_ME_IN, 1 + 1);
        }

    }
}
