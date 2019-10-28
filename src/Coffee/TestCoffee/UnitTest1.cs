using CoffeeBL;
using System;

using Xunit;

namespace TestCoffee
{
    public class ValidationCoffee
    {
        [Fact]
        public void TestPriceNegative()
{
#region  arrange
            Syroup c = new Syroup();
            #endregion
            #region  act
            c.price = -5;
            c.name = "test";
            #endregion
            #region  assert
            Assert.Equal(validation_result.pricing_incorrect, c.IsValid());
            #endregion


        }
        [Fact]
        public void TestPricePositive()
        {
            #region  arrange
            Syroup c = new Syroup();
            #endregion
            #region  act
            c.price = 5;
            c.name = "Mycoffee";
            #endregion
            #region  assert
            Assert.Equal(validation_result.succes, c.IsValid());

            #endregion


        }

        [Fact]
        public void TestWithoutName()
        {
            #region  arrange
            Syroup c = new Syroup();
            #endregion
            #region  act
            c.price = 5;
            c.name = null;
            #endregion
            #region  assert
            Assert.Equal(validation_result.name_inccorect, c.IsValid());

            #endregion


        }

    }
}
