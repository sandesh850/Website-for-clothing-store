using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class LadiesItemsModel : PageModel
    {
        private readonly AppDb _appDb;

        public LadiesItemsModel(AppDb appDb)
        {
            _appDb = appDb;
        }


        public List<Tbl_ItemDetails> Tbl_ItemDetails { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Tbl_ItemDetails = _appDb.Tbl_ItemDetails.Where(x => x.ItemType == "L").ToList();

            //CategoryName = Tbl_ItemDetails[0].CategoryName;

            return Page();
        }

        //public void OnGet()
        //{
        //}
    }
}
