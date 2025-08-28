using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class ProductDetailsPageModel : PageModel
    {
        private readonly AppDb _appDb;

        public ProductDetailsPageModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        [BindProperty]
        public Tbl_ItemDetails? Tbl_ItemDetails { get; set; }

        [BindProperty]
        public string sizes { get; set; }

        [BindProperty]
        public string represent_sizes { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tbl_ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            // Split by comma and trim spaces
            sizes = Tbl_ItemDetails.size;

            var filterSizes = sizes.Split(',').Select(s => s.Trim()).ToList();

            foreach(var filterSize in filterSizes)
            {
                if(filterSize == "S")
                {
                    represent_sizes = "S";
                }
            }



            return Page();
        }

        //public void OnGet()
        //{
        //}
    }
}
