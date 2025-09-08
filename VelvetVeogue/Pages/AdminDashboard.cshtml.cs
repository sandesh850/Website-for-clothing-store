using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly AppDb _appDb;

        public PrivacyModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        [BindProperty]
        public int PendingOrders { get; set; }

        public List<Tbl_OrderDetails> orderdetails { get; set; }


        [BindProperty]
        public int LblInquiriesCount { get; set; }

        public List<Tbl_Inquiries> inquiries { get; set; }


        public int completedOrderCountThisMonth { get; set; }
        public List<Tbl_CompleteOrders> CompleteOrdersTbl { get; set; }

        //Complete orders this year
        public int completedOrderCountThisYear { get; set; }
        public List<Tbl_CompleteOrders> CompleteOrdersTblThisYear { get; set; }

        // contact us list
        public List<TblContactUS> tblcontactUSs { get; set; }

        public IActionResult OnGet()
        {
            orderdetails = _appDb.Tbl_OrderDetails.ToList();
            PendingOrders = orderdetails.Count;

            inquiries = _appDb.Tbl_Inquiries.ToList();
            LblInquiriesCount = inquiries.Count;

            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;

            CompleteOrdersTblThisYear = _appDb.Tbl_CompleteOrders.Where(detail => detail.date.Year == year).ToList();
            completedOrderCountThisYear = CompleteOrdersTblThisYear.Count();

            CompleteOrdersTbl = _appDb.Tbl_CompleteOrders.Where(details => details.date.Month == month && details.date.Year == year).ToList();
            completedOrderCountThisMonth = CompleteOrdersTbl.Count();

            // Use retrieve contact us table details
            tblcontactUSs = _appDb.Tbl_ContactUS.ToList();

            return Page();
        }
    }

}
