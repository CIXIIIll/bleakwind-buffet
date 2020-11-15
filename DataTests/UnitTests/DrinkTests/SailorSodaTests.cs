/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }
        [Fact]
        public void ShouldBeAbleToGetDescription()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", ss.Description);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = false;
            Assert.False(ss.Ice);
            ss.Ice = true;
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }


        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }
        
        [Theory]


        [InlineData(SodaFlavor.Lemon, Size.Small)]
        [InlineData(SodaFlavor.Lemon, Size.Medium)]
        [InlineData(SodaFlavor.Lemon, Size.Large)]

        [InlineData(SodaFlavor.Peach, Size.Small)]
        [InlineData(SodaFlavor.Peach, Size.Medium)]
        [InlineData(SodaFlavor.Peach, Size.Large)]

        [InlineData(SodaFlavor.Watermelon, Size.Small)]
        [InlineData(SodaFlavor.Watermelon, Size.Medium)]
        [InlineData(SodaFlavor.Watermelon, Size.Large)]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal($"{ss.Size} {ss.Flavor} Sailor Soda", ss.ToString());
        }
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = true;
            });

            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = false;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Medium;
            });

            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Small;
            });
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Large;
            });
        }
                [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Blackberry;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Grapefruit;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Lemon;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Peach;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Watermelon;
            });
        }
    }
}
