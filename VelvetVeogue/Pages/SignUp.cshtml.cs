using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;
using Microsoft.EntityFrameworkCore;

namespace VelvetVeogue.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage ="Username is required")]
        public string? tbxusername { get; set; } 

        [BindProperty]
        [Required(ErrorMessage ="Password is required")]
        public string? tbxpassword { get; set; }


        [BindProperty]
        [Required(ErrorMessage ="Please type the confirm password")]
        [Compare("tbxpassword", ErrorMessage ="Password and confirm password do not match")]
        public string? tbxConfirmpassword { get; set; }


        [BindProperty]
        public string? error {  get; set; }

        // Connecte to the database through dependency injection 
        private readonly AppDb _AppDb;

        public SignUpModel(AppDb appDb)
        {
            _AppDb = appDb;
        }

        public List<TblLogin> TblLogin { get; set; }
        public int RowCount { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid) // Validation (This code is link with above validations)
            {
                return Page();
            }

            TblLogin = await _AppDb.TblLogins.ToListAsync();
            RowCount = TblLogin.Count;

            if(RowCount > 0)
            {
                ModelState.AddModelError("error", "You can't add another login");
            }
            else
            {
                // Inserting data into the database
                var newTable = new TblLogin
                {
                    Username = tbxusername,
                    Password = tbxpassword
                };

                _AppDb.TblLogins.Add(newTable);
                await _AppDb.SaveChangesAsync();

                return RedirectToPage("/index");
            }

                return Page();
           
        }

        public void OnGet()
        {
        }
    }
}
