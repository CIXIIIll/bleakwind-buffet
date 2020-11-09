using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTest
{
    public class menuTest
    {
        [Fact]
        public void SouldAddAllEntrees()
        {
            IEnumerable<IOrderItem> x = Menu.Entrees();
            Assert.Collection(x,
                item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                item => Assert.IsAssignableFrom<GardenOrcOmelette>(item),
                item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                item => Assert.IsAssignableFrom<ThugsTBone>(item)
                );
        }
        [Fact]
        public void ShouldAddAllSideBySize()
        {
            IEnumerable<IOrderItem> x = Menu.Sides();
            Assert.Collection(x,
                item => Assert.Equal(Size.Small, ((DragonbornWaffleFries)item).Size),
                item => Assert.Equal(Size.Medium, ((DragonbornWaffleFries)item).Size),
                item => Assert.Equal(Size.Large, ((DragonbornWaffleFries)item).Size),
                item => Assert.Equal(Size.Small, ((FriedMiraak)item).Size),
                item => Assert.Equal(Size.Medium, ((FriedMiraak)item).Size),
                item => Assert.Equal(Size.Large, ((FriedMiraak)item).Size),
                item => Assert.Equal(Size.Small, ((MadOtarGrits)item).Size),
                item => Assert.Equal(Size.Medium, ((MadOtarGrits)item).Size),
                item => Assert.Equal(Size.Large, ((MadOtarGrits)item).Size),
                item => Assert.Equal(Size.Small, ((VokunSalad)item).Size),
                item => Assert.Equal(Size.Medium, ((VokunSalad)item).Size),
                item => Assert.Equal(Size.Large, ((VokunSalad)item).Size)
                );
        }
        [Fact]
        public void ShouldAddAllSide()
        {
            IEnumerable<IOrderItem> x = Menu.Sides();
            Assert.Collection(x,
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item)
                );
        }

        [Fact]
        public void ShouldAddAllDrinkForFlavor()
        {
            IEnumerable<IOrderItem> x = Menu.Drinks();
            Assert.Collection(x,
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor),
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size)
                );
        }
        [Fact]
        public void ShouldAddAllDrinkBySize()
        {
            IEnumerable<IOrderItem> x = Menu.Drinks();
            Assert.Collection(x,
                ///Soda
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),

                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),

                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),

                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),

                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),

                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                ///juice
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                ///coffee
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                ///milk
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size),
                ///water
                item => Assert.Equal(Size.Small, ((Drink)item).Size),
                item => Assert.Equal(Size.Medium, ((Drink)item).Size),
                item => Assert.Equal(Size.Large, ((Drink)item).Size)
                );
        }
        [Fact]
        public void ShouldFiltByCategorywithNull()
        {
            IEnumerable<IOrderItem> All = Menu.All;
            List<string> list = new List<string>();
            IEnumerable<IOrderItem> x = Menu.FilterByCategory(All, list);
            Assert.Equal(All, x);
        }
        [Fact]
        public void ShouldFiltByCategorywithAll()
        {
            IEnumerable<IOrderItem> All = Menu.All;
            List<string> list = new List<string> { "Entrees", "Drinks", "Sides" };
            IEnumerable<IOrderItem> x = Menu.FilterByCategory(All, list);
            Assert.Equal(All, x);
        }
        [Fact]
        public void ShouldFiltByCategorywithEntrees()
        {
            IEnumerable<IOrderItem> All = Menu.All;
            List<string> list = new List<string> { "Entrees" };
            IEnumerable<IOrderItem> x = Menu.FilterByCategory(All, list);
            Assert.Collection(x,
                item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                item => Assert.IsAssignableFrom<GardenOrcOmelette>(item),
                item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                item => Assert.IsAssignableFrom<ThugsTBone>(item)
           );
        }
        [Fact]
        public void ShouldFiltByCategorywithDrinksinSameCount()
        {
            IEnumerable<IOrderItem> All = Menu.All;
            List<string> list = new List<string> { "Drinks" }; 
            IEnumerable<IOrderItem> x = Menu.FilterByCategory(All, list);
            Assert.Equal(Menu.Drink.Count(), x.Count());
        }
        [Fact]
        public void ShouldFiltByCategorywithSidesinSameCount()
        {
            IEnumerable<IOrderItem> All = Menu.All;
            List<string> list = new List<string> { "Sides" };
            IEnumerable<IOrderItem> x = Menu.FilterByCategory(All, list);
            Assert.Equal(Menu.Side.Count(), x.Count());
        }
        [Theory]
        [InlineData("Soda", 18)]
        [InlineData("-", 1)]
        [InlineData("Burger", 1)]
        [InlineData("9", 0)]
        public void ShouldSearchwithStringinSameCount(string searchTerm, int count)
        {
            IEnumerable<IOrderItem> x = Menu.Search(Menu.All, searchTerm);
            Assert.Equal(count, x.Count());
        }
        [Fact]
        public void ShouldSearchwithNullinSameCount()
        {
            IEnumerable<IOrderItem> x = Menu.Search(Menu.All, "");
            Assert.Equal(Menu.All.Count(), x.Count());
        }
        [Fact]
        public void ShouldSearchwithCaloriesinSameCount()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByCalories(Menu.All, 0, 100);
            Assert.Equal(17, x.Count());
        }
        [Fact]
        public void ShouldSearchCalorieswithNullinSameCount()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByCalories(Menu.All, null, null);
            Assert.Equal(Menu.All.Count(), x.Count());
        }
        [Fact]
        public void ShouldSearchCalorieswithMinNull()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByCalories(Menu.All, null, 0);
            Assert.Collection(x, item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item)
            );
        }
        [Fact]
        public void ShouldSearchCalorieswithMaxNull()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByCalories(Menu.All, 500, null);
            Assert.Collection(x,
                 item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                 item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                 item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                 item => Assert.IsAssignableFrom<ThugsTBone>(item)
                );
        }


        [Fact]
        public void ShouldSearchwithPrice()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByPrice(Menu.All, 5, 10);
            Assert.Collection(x,
             item => Assert.IsAssignableFrom<BriarheartBurger>(item),
             item => Assert.IsAssignableFrom<DoubleDraugr>(item),
             item => Assert.IsAssignableFrom<PhillyPoacher>(item),
             item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
             item => Assert.IsAssignableFrom<ThalmorTriple>(item),
             item => Assert.IsAssignableFrom<ThugsTBone>(item)
         );
        }
        [Fact]
        public void ShouldSearchPricewithNullinSameCount()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByPrice(Menu.All, null, null);
            Assert.Equal(Menu.All.Count(), x.Count());
        }
        [Fact]
        public void ShouldSearchPricewithMinNull()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByPrice(Menu.All, null, 0);
            Assert.Collection(x, item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item)
                );
        }
        [Fact]
        public void ShouldSearchPricewithMaxNull()
        {
            IEnumerable<IOrderItem> x = Menu.FilterByPrice(Menu.All,7, null);
            Assert.Collection(x,
            item => Assert.IsAssignableFrom<DoubleDraugr>(item),
            item => Assert.IsAssignableFrom<PhillyPoacher>(item),
            item => Assert.IsAssignableFrom<ThalmorTriple>(item)
            );
        }
        [Fact]
        public void ShouldAddAllItemInFullMenu()
        {
            IEnumerable<IOrderItem> m = Menu.FullMenu();
            Assert.Collection(m,
                item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                item => Assert.IsAssignableFrom<GardenOrcOmelette>(item),
                item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                item => Assert.IsAssignableFrom<ThugsTBone>(item),
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<FriedMiraak>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item),
                item => Assert.IsAssignableFrom<VokunSalad>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),
                item => Assert.IsAssignableFrom<SailorSoda>(item),

                item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),

                item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),

                item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                item => Assert.IsAssignableFrom<MarkarthMilk>(item),

                item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item),
                item => Assert.IsAssignableFrom<WarriorWater>(item)
                );

        }
    }
}
