using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class UpdateItemDetailsModel : PageModel
    {
        private readonly AppDb _appDb;

        public UpdateItemDetailsModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        [BindProperty]
        public Tbl_ItemDetails? ItemDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            return Page();
        }

        //public void OnGet()
        //{
        //}
    }
}
