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

        public IActionResult OnGet()
        {
            orderdetails = _appDb.Tbl_OrderDetails.ToList();
            PendingOrders = orderdetails.Count;

            return Page();
        }
    }

}
