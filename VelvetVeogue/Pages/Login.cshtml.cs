using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty,Required(ErrorMessage ="Please enter the username")]
        public string tbxusername { get; set; }

        [BindProperty,Required(ErrorMessage ="Please enter the password")]
        public string tbxpassword { get; set; }

        public readonly AppDb _appDb;

        public LoginModel(AppDb appDb)
        {
            _appDb = appDb;
        }

        public List<TblLogin>? TblLogin { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string existing_username = "";
            string existing_password = "";

            TblLogin = _appDb.TblLogins.ToList();

            if(TblLogin != null)
            {
                existing_username = TblLogin[0].Username;
                existing_password = TblLogin[0].Password;
            }

           

            if(existing_username == tbxusername && existing_password == tbxpassword)
            {
                HttpContext.Session.SetString("Login","true");
                return RedirectToPage("/index");
            }
            else
            {
                return Page();
            }

        }

        //public void OnGet()
        //{
        //}
    }
}
