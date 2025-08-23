using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class RemoveItemDetailsModel : PageModel
    {
        private readonly AppDb _appDb;

        public RemoveItemDetailsModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        [BindProperty]
        public Tbl_ItemDetails? ItemDetails { get; set; }

        // Use to find selected record
        public async Task<IActionResult> OnGetAsync(int id)
        {
            ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            var item = await _appDb.Tbl_ItemDetails.FindAsync(id);

            if (item != null)
            {
                _appDb.Tbl_ItemDetails.Remove(item);
                await _appDb.SaveChangesAsync();
            }

            return RedirectToPage("/UpdateOrRemove");
        }

        //public void OnGet()
        //{
        //}
    }
}
