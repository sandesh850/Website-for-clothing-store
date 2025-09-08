using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class InquiryAdminViewModel : PageModel
    {
        private readonly AppDb _appDb;

        public InquiryAdminViewModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public List<Tbl_Inquiries> Inquiriestbl { get; set; }  

        public IActionResult OnGet()
        {
            Inquiriestbl = _appDb.Tbl_Inquiries.ToList();

            return Page();
        }
    }
}
