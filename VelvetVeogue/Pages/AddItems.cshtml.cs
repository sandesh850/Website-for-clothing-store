using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class AddItemsModel : PageModel
    {
        /// <summary>
        /// Variables
        /// </summary>

        [BindProperty, Required(ErrorMessage = "Please select a image")]
        public IFormFile? inputImg { get; set; } // This variable create after intial creation || use for image uploading


        [BindProperty]
        [Required(ErrorMessage = "Please type the Category Name")]
        public string tbxCategoryName { get; set; }

        [BindProperty]
        public string tbxName { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the color")]
        public string tbxcolor { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the sizes")]
        public string tbxsizes { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the Available Qty")]
        public int tbxAvailableQTY { get; set; }


        [BindProperty, Required(ErrorMessage = "Please enter the Price")]
        public double tbxprice { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the Item Type")]
        public string tbxItemType { get; set; }


        /// <summary>
        /// Dependency injectios
        /// </summary>
        private readonly AppDb _AppDb;

        public AddItemsModel(AppDb appDb)
        {
            _AppDb = appDb;
        }


        // use to calculate category code
        public Tbl_ItemDetails? Tbl_ItemDetails_last_record { get; set; }
        //public int CategoryCodeFromDB { get; set; }



        // use to calculate category code
        public int tbxITMCode { get; set; }



        public async Task<IActionResult> OnGetAsync()
        {
            //calculating category code
           Tbl_ItemDetails_last_record = await _AppDb.Tbl_ItemDetails.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            if (Tbl_ItemDetails_last_record == null)
            {
                tbxITMCode = tbxITMCode + 1;
            }
            else if (Tbl_ItemDetails_last_record != null)
            {
                tbxITMCode = Tbl_ItemDetails_last_record.ItemCode + 1;
            }



            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            // calculating category code
            Tbl_ItemDetails_last_record = await _AppDb.Tbl_ItemDetails.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            if (Tbl_ItemDetails_last_record == null)
            {
                tbxITMCode = tbxITMCode + 1;
            }
            else if (Tbl_ItemDetails_last_record != null)
            {
                tbxITMCode = Tbl_ItemDetails_last_record.ItemCode + 1;
            }

            // Special code | converting image into byte
            byte[]? imgBytes = null;

            if (inputImg != null)
            {
                using (var ms = new MemoryStream())
                {
                    await inputImg.CopyToAsync(ms);
                    imgBytes = ms.ToArray();
                }
            }

            // Validation (This code is link with above validations)
            if (!ModelState.IsValid)
            {

                return RedirectToPage("/AddItems");
            }
            else
            {
                var TblItemDetail = new Tbl_ItemDetails
                {
                    ItemCode = tbxITMCode,
                    CategoryName = tbxCategoryName,
                    Name = tbxName,
                    Color = tbxcolor,
                    size = tbxsizes,
                    AvailableQty = tbxAvailableQTY,
                    Price = tbxprice,
                    img = imgBytes,
                    ItemType = tbxItemType,

                };

                _AppDb.Tbl_ItemDetails.Add(TblItemDetail);
                await _AppDb.SaveChangesAsync();

                return RedirectToPage("/AddItems");
            }

            // Inserting data into the database

        }

        //public void OnGet()
        //{

        //    //}
        //}
    } 

}
