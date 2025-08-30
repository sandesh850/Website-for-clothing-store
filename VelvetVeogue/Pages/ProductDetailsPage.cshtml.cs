using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;
using VelvetVeogue.PublicItems;

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
        public string represent_sizes01 { get; set; }


        [BindProperty]
        public string represent_sizes02 { get; set; }


        [BindProperty]
        public string represent_sizes03 { get; set; }


        [BindProperty]
        public string ItemType { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tbl_ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            //checking item type
            if(Tbl_ItemDetails != null)
            {
                if (Tbl_ItemDetails.ItemType == "G")
                {
                    ItemType = "Gent Item";

                }
                else if (Tbl_ItemDetails.ItemType == "L")
                {
                    ItemType = "Ladies Item";
                }
                else if (Tbl_ItemDetails.ItemType == "K")
                {
                    ItemType = "Kids Item";
                }


                // Split by comma and trim spaces
                sizes = Tbl_ItemDetails.size;

                var filterSizes = sizes.Split(',').Select(s => s.Trim()).ToList();

                foreach (var data in filterSizes)
                {
                    if (data == "S")
                    {
                        represent_sizes01 = "S";
                    }
                    else if (data == "M")
                    {
                        represent_sizes02 = "M";
                    }
                    else if (data == "L")
                    {
                        represent_sizes03 = "L";
                    }
                }
            }
           

           



            return Page();
        }

        // sending data to public variables
        [BindProperty,Required(ErrorMessage ="Please type the sizes you want")]
        public string? tbxSizesUserWant {  get; set; }

        // On post
       //public async Task<IActionResult> OnPost()
       //{

       //     /* // Reload product from DB using Id
       //     if (Tbl_ItemDetails != null)
       //     {
       //         Tbl_ItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

               
       //     }

       //     //// Item type checking
       //     //if (Tbl_ItemDetails.ItemType == "G")
       //     //{
       //     //    ItemType = "Gent Item";

       //     //}
       //     //else if (Tbl_ItemDetails.ItemType == "L")
       //     //{
       //     //    ItemType = "Ladies Item";
       //     //}
       //     //else if (Tbl_ItemDetails.ItemType == "K")
       //     //{
       //     //    ItemType = "Kids Item";
       //     //}

       //     // Save public variables
       //     PublicVariables publicVariables = new PublicVariables
       //     {
       //         CategoryName = Tbl_ItemDetails.CategoryName,
       //         price = Tbl_ItemDetails.Price,
       //         sizes = tbxSizesUserWant,
       //         color = Tbl_ItemDetails.Color,
       //         Image = Tbl_ItemDetails.img,
       //         Public_variable_ItemType = ItemType 
                
       //     };

       //     if(publicVariables.CategoryName != string.Empty)
       //     {

       //         return RedirectToPage("PaymentAndOrderConfirmation");
       //     }*/

       //     return RedirectToPage("PaymentAndOrderConfirmation");



       //}

        //public void OnGet()
        //{
        //}
    }
}
