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

        // Use to find selected record
        public async Task<IActionResult> OnGetAsync(int id)
        {
            ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            return Page();
        }

        // Updating record
        public Tbl_ItemDetails? Existing_ItemDetails { get; set; }

        public IFormFile? NewImage { get; set; }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            // Retrieving existing items
            Existing_ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

           
            Existing_ItemDetails.CategoryName = ItemDetails.CategoryName;
            Existing_ItemDetails.Name = ItemDetails.Name;
            Existing_ItemDetails.Color = ItemDetails.Color;
            Existing_ItemDetails.size = ItemDetails.size;
            Existing_ItemDetails.AvailableQty = ItemDetails.AvailableQty;
            Existing_ItemDetails.Price = ItemDetails.Price;

            // updating image
            if(NewImage != null && NewImage.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await NewImage.CopyToAsync(ms);
                    Existing_ItemDetails.img = ms.ToArray();
                }
            }
          
            await _appDb.SaveChangesAsync();

            return RedirectToPage("/UpdateOrRemove");
        }

        //public void OnGet()
        //{
        //}
    }
}
