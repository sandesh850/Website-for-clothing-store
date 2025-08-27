using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class InquiriesModel : PageModel
    {
        [BindProperty, Required(ErrorMessage = "Please Type the Message")]
        public string tbxSubject { get; set; } = string.Empty;

        [BindProperty, Required(ErrorMessage = "Please Type the Message")]
        public string tbxMessage { get; set; } = string.Empty;



        private readonly AppDb _appDb;

        public InquiriesModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var TblInquiries = new Tbl_Inquiries
                {
                    sibject = tbxSubject,
                    Message = tbxMessage
                   
                };

                _appDb.Tbl_Inquiries.Add(TblInquiries);
                await _appDb.SaveChangesAsync();

                return RedirectToPage("index");

            }

            return Page();

        }

        //public void OnGet()
        //{
        //}
    }
}
