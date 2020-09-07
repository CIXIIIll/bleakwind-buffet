/*
 * Author: Haoran An
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWaterTests.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.True(ww.Ice);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.Equal(Size.Small, ww.size);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.size = Size.Medium;
            Assert.Equal(Size.Medium, ww.size);
            ww.size = Size.Large;
            Assert.Equal(Size.Large, ww.size);
            ww.size = Size.Small;
            Assert.Equal(Size.Small, ww.size);
        }
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }


        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.size = size;
            Assert.Equal(price, ww.Pirce);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
