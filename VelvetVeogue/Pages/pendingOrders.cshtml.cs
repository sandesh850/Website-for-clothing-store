using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class pendingOrdersModel : PageModel
    {
        private readonly AppDb _appDb;

        public pendingOrdersModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public List<Tbl_OrderDetails>? tblPending { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            tblPending = _appDb.Tbl_OrderDetails.ToList();

            return Page();
        }

        
    }
}
