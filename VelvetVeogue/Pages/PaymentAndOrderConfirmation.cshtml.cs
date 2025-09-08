using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;
using VelvetVeogue.PublicItems;

namespace VelvetVeogue.Pages
{
    public class PaymentAndOrderConfirmationModel : PageModel
    {
        [BindProperty,Required(ErrorMessage ="Please enter a email address")]
        public string tbxEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter a address")]
        public string tbxaddress { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter a contact No")]
        public string tbxContactNo { get; set; }

        [BindProperty]
        public string cmbPaymentMethod { get; set; }

        [BindProperty]
        public int tbxcardNo { get; set; }

        [BindProperty]
        public string tbxcardDate { get; set; }

        [BindProperty]
        public int tbxcvcNo { get; set; }

        // Dependency injection
        private readonly AppDb _appDb;

        public PaymentAndOrderConfirmationModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        [BindProperty]
        public Tbl_ItemDetails? TblItemDetails { get; set; }

        //[BindProperty]
        //public int? ID { get; set; }

        [BindProperty]
        public string? userWantSizeL { get; set; }

        public void OnGet()
        {
            userWantSizeL = HttpContext.Session.GetString("id");
        }

        [BindProperty]
        public DateTime? OrderDate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var id = HttpContext.Session.GetInt32("id");

            OrderDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            TblItemDetails = await _appDb.Tbl_ItemDetails.FindAsync(id);

            //if(!ModelState.IsValid)
            //{
            //    return Page();
            //}

            byte[]? img = null;
            
            if(TblItemDetails != null)
            {
                img = TblItemDetails.img;

            }

            //var CardNo = HttpContext.Session.GetInt32("tbxcardNo");

            var tblOrder_details = new Tbl_OrderDetails
            {
                ItemType =HttpContext.Session.GetString("ItemType"),
                category = HttpContext.Session.GetString("CategoryName"),
                price = TblItemDetails.Price,
                color = HttpContext.Session.GetString("color"),
                sizes = HttpContext.Session.GetString("UserSize"),
                address = tbxaddress,
                contactNo = tbxContactNo,
                email = tbxEmail,
                paymentMethod = cmbPaymentMethod,
             
                cardDate = tbxcardDate,
                CVCNO = tbxcvcNo,
                img =img,
                date=Convert.ToDateTime(OrderDate),
                CardNo = tbxcardNo.ToString()
            };


            _appDb.Tbl_OrderDetails.Add(tblOrder_details);
            await _appDb.SaveChangesAsync();

            return RedirectToPage("Index");
        }

       
    }
}
