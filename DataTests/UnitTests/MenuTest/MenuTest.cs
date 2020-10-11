using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

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
