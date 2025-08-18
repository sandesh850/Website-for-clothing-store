using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class AddItemsModel : PageModel
    {
        /// <summary>
        /// Variables
        /// </summary>
        [BindProperty]
        [Required(ErrorMessage ="Please type the Category Name")]
        public string tbxCategoryName { get; set; }

        [BindProperty]
        public string tbxName { get; set; }

        [BindProperty,Required(ErrorMessage ="Please enter the color")]
        public string tbxcolor { get; set; }

        [BindProperty,Required(ErrorMessage ="Please enter the sizes")]
        public string tbxsizes { get; set; }

        [BindProperty,Required(ErrorMessage ="Please enter the Available Qty")]
        public int? tbxAvailableQTY { get; set; }


        [BindProperty, Required(ErrorMessage = "Please enter the Price")]
        public double? tbxprice { get; set; }


        /// <summary>
        /// Dependency injectios
        /// </summary>
        private readonly AppDb _AppDb;

        public AddItemsModel(AppDb appDb)
        {
            _AppDb = appDb;
        }

        public async Task<IActionResult> OnPostAsync()
        {


            return Page();
        }

        public void OnGet()
        {
        }
    }
}
