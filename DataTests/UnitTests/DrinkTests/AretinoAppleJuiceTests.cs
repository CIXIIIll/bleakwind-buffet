/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            Assert.Equal(Size.Small, aaj.size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            aaj.Ice = true;
            Assert.True(aaj.Ice);
            aaj.Ice = false;
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();

            aaj.size = Size.Medium;
            Assert.Equal(Size.Medium, aaj.size);
            aaj.size = Size.Large;
            Assert.Equal(Size.Large, aaj.size);           
            aaj.size = Size.Small;
            Assert.Equal(Size.Small, aaj.size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            aaj.size = size;
            Assert.Equal(price, aaj.Pirce);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            aaj.size = size;
            Assert.Equal(cal, aaj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            aaj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aaj.SpecialInstructions);
            else Assert.Empty(aaj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            ArentinoAppleJuice aaj = new ArentinoAppleJuice();
            aaj.size = size;
            Assert.Equal(name, aaj.ToString());
        }
    }
}