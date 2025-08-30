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

      

        [BindProperty]
        public int ID { get; set; }

        // sending data to payment page
        [BindProperty, Required(ErrorMessage = "Please type the sizes you want")]
        public string? tbxSizesUserWant { get; set; }


        [BindProperty]
        public string? ItemTypePost { get; set; }

        [BindProperty]
        public string? CategoryNamePost { get; set; }


        [BindProperty]
        public double? Price { get; set; }

        [BindProperty]
        public string? color02 { get; set; }

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

               ItemTypePost = Tbl_ItemDetails.ItemType;
               CategoryNamePost = Tbl_ItemDetails.CategoryName;
               Price = Tbl_ItemDetails.Price;
               color02 = Tbl_ItemDetails.Color;
               ID = Tbl_ItemDetails.Id;
            }
           

            return Page();
        }


      

        public IActionResult OnPost()
        {

            if(Tbl_ItemDetails != null)
            {
                HttpContext.Session.SetString("ItemType", ItemTypePost ?? "");
                HttpContext.Session.SetString("CategoryName", CategoryNamePost ?? "");
                HttpContext.Session.SetString("Price", Price.ToString() ?? "0");
                HttpContext.Session.SetString("UserSize", tbxSizesUserWant ?? "");
                HttpContext.Session.SetString("color",color02 ?? "");
                HttpContext.Session.SetInt32("id", ID);

                //HttpContext.Session.SetString("ItemType",Tbl_ItemDetails.ItemType);
                //HttpContext.Session.SetString("CategoryName", Tbl_ItemDetails.CategoryName);
                ////HttpContext.Session.SetString("ItemType", Tbl_ItemDetails.ItemType);
                //HttpContext.Session.SetString("Price", Tbl_ItemDetails.Price.ToString());
                ////HttpContext.Session.SetString("ItemType", Tbl_ItemDetails.ItemType);
                //HttpContext.Session.SetString("UserSize", tbxSizesUserWant);
                ////HttpContext.Session.SetString("ItemType", Tbl_ItemDetails.ItemType);
                //HttpContext.Session.SetString("color", Tbl_ItemDetails.Color);

                return RedirectToPage ("PaymentAndOrderConfirmation");

            }

            return Page();  

           
            

        }

        //public void OnGet()
        //{
        //}
    }
}
