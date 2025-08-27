using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class ContactUSModel : PageModel
    {
        [BindProperty,Required(ErrorMessage ="Please Type a Full Name")]
        public string tbxFullName { get; set; }

        [BindProperty, Required(ErrorMessage = "Please Type a Email")]
        public string tbxEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Please Type the Message")]
        public string tbxMessage { get; set; }



        private readonly AppDb _appDb;

        public ContactUSModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                var TblContactUS = new TblContactUS
                {
                    FullName = tbxFullName,
                    Email = tbxEmail,
                    message = tbxMessage
                };

                _appDb.Tbl_ContactUS.Add(TblContactUS);
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
