using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class GentsItemsModel : PageModel
    {
        private readonly AppDb _appDb;

        public GentsItemsModel(AppDb appDb)
        {
            _appDb = appDb;
        }

       
        public string CategoryName { get; set; }

        public List<Tbl_ItemDetails> Tbl_ItemDetails { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Tbl_ItemDetails = _appDb.Tbl_ItemDetails.ToList();

            CategoryName = Tbl_ItemDetails[0].CategoryName;

            return Page();
        }
    }
}
