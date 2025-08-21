using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class UpdateOrRemoveModel : PageModel
    {
        private readonly AppDb _appDb;

        public UpdateOrRemoveModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public List<Tbl_ItemDetails> Tbl_ItemDetails { get; set; }  

        public async Task<IActionResult> OnGetAsync()
        {
            Tbl_ItemDetails = _appDb.Tbl_ItemDetails.ToList();

            return Page();
        }
    }
}
