/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.False(chf.Ice);
        }
        [Fact]
        public void ShouldBeAbleToGetDescription()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", chf.Description);
        }
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.False(chf.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.False(chf.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Ice = true;
            Assert.True(chf.Ice);
            chf.Ice = false;
            Assert.False(chf.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Decaf = true;
            Assert.True(chf.Decaf);
            chf.Decaf = false;
            Assert.False(chf.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.RoomForCream = true;
            Assert.True(chf.RoomForCream);
            chf.RoomForCream = false;
            Assert.False(chf.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();         
            chf.Size = Size.Medium;
            Assert.Equal(Size.Medium, chf.Size);
            chf.Size = Size.Large;
            Assert.Equal(Size.Large, chf.Size);
            chf.Size = Size.Small;
            Assert.Equal(Size.Small, chf.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Size = size;
            Assert.Equal(price, chf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Size = size;
            Assert.Equal(cal, chf.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Ice = includeIce;
            chf.RoomForCream = includeCream;
            if(includeCream)Assert.Contains("Add cream", chf.SpecialInstructions);
            if (includeIce) Assert.Contains("Add ice", chf.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(chf.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            chf.Size = size;
            chf.Decaf = decaf;
            Assert.Equal(name, chf.ToString());
        }
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chf);
        }
        [Fact]

        public void ChangingIceNotifiesIceProperty()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();

            Assert.PropertyChanged(chf, "Ice", () =>
            {
                chf.Ice = true;
            });

            Assert.PropertyChanged(chf, "Ice", () =>
            {
                chf.Ice = false;
            });
        }
        [Fact]
        public void ChangingCreamNotifiesCreamProperty()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();

            Assert.PropertyChanged(chf, "RoomForCream", () =>
            {
                chf.RoomForCream = true;
            });

            Assert.PropertyChanged(chf, "RoomForCream", () =>
            {
                chf.RoomForCream = false;
            });
        }
        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();

            Assert.PropertyChanged(chf, "Decaf", () =>
            {
                chf.Decaf = true;
            });

            Assert.PropertyChanged(chf, "Decaf", () =>
            {
                chf.Decaf = false;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            CandlehearthCoffee chf = new CandlehearthCoffee();

            Assert.PropertyChanged(chf, "Size", () =>
            {
                chf.Size = Size.Medium;
            });

            Assert.PropertyChanged(chf, "Size", () =>
            {
                chf.Size = Size.Small;
            });
            Assert.PropertyChanged(chf, "Size", () =>
            {
                chf.Size = Size.Large;
            });
        }
    }
}
