using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.DrinksMenu;
using PointOfSale.EntreesMenu;
using PointOfSale.SidesMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        List<IOrderItem> list = new List<IOrderItem>();
        /// <summary>
        /// Constructs a new MenuSelection
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// Open the Briarheart Burger list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        void AddBriarheartBurger(object sender, EventArgs e)
        {
            BriarheartBurgerMenu b = new BriarheartBurgerMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = b;
        }
        /// <summary> 
        /// Adds the item in the list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = null;
            Done.Visibility = Visibility.Hidden;
        }
        /// <summary> 
        /// Open the Double Draugr list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            DoubleDraugrMenu d = new DoubleDraugrMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = d;
        }
        /// <summary> 
        /// Open the Garden Orc Omelette list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            GardenOrcOmeletteMenu g = new GardenOrcOmeletteMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = g;
        }
        /// <summary> 
        /// Open the Thalmor Triple list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            ThalmorTripleMenu tt = new ThalmorTripleMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = tt;
        }
        /// <summary> 
        /// Open the Smokehouse Skeleton list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeletonMenu s = new SmokehouseSkeletonMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = s;
        }
        /// <summary> 
        /// Open the Philly Poacher list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            PhillyPoacherMenu p = new PhillyPoacherMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = p;
        }
        /// <summary> 
        /// Open the Thugs T Bone list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            ThugsTBoneMenu t = new ThugsTBoneMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = t;
        }
        /// <summary> 
        /// Open the Sailor Soda list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            SailorSodaMenu s = new SailorSodaMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = s;
        }
        /// <summary> 
        /// Open the Markarth Milklist list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            MarkarthMilkMenu mm = new MarkarthMilkMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = mm;
        }
        /// <summary> 
        /// Open the Aretino Apple Juice list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuiceMenu a = new AretinoAppleJuiceMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = a;
        }
        /// <summary> 
        /// Open the Candlehearth Coffee list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffeeMenu c = new CandlehearthCoffeeMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = c;
        }
        /// <summary> 
        /// Open the Warrior Water list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            WarriorWaterMenu w = new WarriorWaterMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = w;
        }
        /// <summary> 
        /// Open the Vokun Salad list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            VokunSaladMenu v = new VokunSaladMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = v;
        }
        /// <summary> 
        /// Open the Fried Miraak list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            FriedMiraakMenu f = new FriedMiraakMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = f;
        }
        /// <summary> 
        /// Open the Mad Otar Grits list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            MadOtarGritsMenu m = new MadOtarGritsMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = m;
        }
        /// <summary> 
        /// Open Dragonborn Waffle Fries list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFriesMenu d = new DragonbornWaffleFriesMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = d;
        }
    }
}
