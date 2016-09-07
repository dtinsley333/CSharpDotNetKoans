using Xunit;
using NSS_Koans;

namespace NSS_Koans_Tester
{

    public class Null
    {
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutNullNullIsNotAnObject()
        {
            Assert.True(typeof(object).IsAssignableFrom(null)); //not everything is an object
        }

        [Fact]
        public void AboutNullCheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj == FILL_ME_IN);
        }

        [Fact]
        public void AboutNullABetterWayToCheckThatAnObjectIsNull()
            //Use this method to test if an objecct is null
        {
            object obj = null;
            Assert.Null(FILL_ME_IN);
        }

        [Fact]
        public void AboutNullAWayNotToCheckThatAnObjectIsNull()
            //Don't do this
        {
            object obj = null;
            Assert.True(obj == FILL_ME_IN);
        }

        [Fact]
        public void CheckForNullableIntValue()
        /*It is ok for some values to be nullable, example a
        new customer may have an account but
        no purchases*/
        {
            double? purchaseTotal = null;
            Assert.Equal(2.55,purchaseTotal);
        }

        [Fact]
        public void DoesIntHaveValue()
        /* You find out if a value is null by using the HasValue property*/
        {
            double? purchaseTotal = null;
            Assert.True(purchaseTotal.HasValue);
        }

    }
}
