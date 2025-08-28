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

        public List<Tbl_ItemDetails>? Tbl_ItemDetails { get; set; }

        //public Task<IActionResult> OnGetAsync()
        //{

        //}

        //public void OnGet()
        //{
        //}
    }
}
