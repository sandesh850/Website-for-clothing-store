using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

       
        public Tbl_ItemDetails? Tbl_ItemDetails_last_record { get; set; }
        public int CategoryCodeFromDB { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            Tbl_ItemDetails_last_record = await _AppDb.Tbl_ItemDetails.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            if (Tbl_ItemDetails_last_record != null)
            {
                CategoryCodeFromDB = Tbl_ItemDetails_last_record.CategoryCode;
            }


            return Page();
        }

        public void OnGet()
        {

        }
    }
}
