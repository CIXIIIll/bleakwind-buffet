
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
            Menus = Menu.Search(Menus, SearchTerms);
            Menus = Menu.FilterByCategory(Menus, ItemsTypes);
            Menus = Menu.FilterByCalories(Menus, CaloriesMin, CaloriesMax);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
        }

    }
}
