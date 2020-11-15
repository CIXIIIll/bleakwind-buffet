
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// The current Items Types
        /// </summary>
        [BindProperty]
        public string[] ItemsTypes { get; set; }
        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }
        /// <summary>
        /// The current minimum Calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }
        /// <summary>
        /// The current maximum Calories 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }
        /// <summary>
        /// The current minimum Price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }
        /// <summary>
        /// The current maximum Price 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The Menus to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> Menus = Menu.FullMenu();
        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            ItemsTypes = Request.Query["ItemsTypes"];
            if (SearchTerms != null)
            {
                Menus = Menus.Where(item => item.ToString() != null && (item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)|| item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)));
            }
            if(ItemsTypes != null && ItemsTypes.Length != 0)
            {
                Menus = Menus.Where(item => (ItemsTypes.Contains("Entrees") && item is Entree)|| (ItemsTypes.Contains("Drinks") && item is BleakwindBuffet.Data.Drinks.Drink) || (ItemsTypes.Contains("Sides") && item is BleakwindBuffet.Data.Sides.Side));
            }
            if(!(CaloriesMin == null && CaloriesMax == null))
            {
                if(CaloriesMin == null)
                {
                    Menus = Menus.Where(item => item.Calories <= CaloriesMax);
                }
                else if (CaloriesMax == null)
                {
                    Menus = Menus.Where(item => item.Calories >= CaloriesMin);
                }
                else
                {
                    Menus = Menus.Where(item => (item.Calories >= CaloriesMin && item.Calories <= CaloriesMax));
                }
               
            }
            if (!(PriceMin == null && PriceMax == null))
            {
                if (PriceMin == null)
                {
                    Menus = Menus.Where(item => item.Price <= PriceMax);
                }
                else if (PriceMax == null)
                {
                    Menus = Menus.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    Menus = Menus.Where(item => (item.Price >= PriceMin && item.Price <= PriceMax));
                }
            }
        }

    }
}
