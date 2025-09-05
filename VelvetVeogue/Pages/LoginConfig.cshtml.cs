using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VelvetVeogue.Data;
using VelvetVeogue.Models;

namespace VelvetVeogue.Pages
{
    public class LoginConfigModel : PageModel
    {
        private readonly AppDb _appDb;

        public LoginConfigModel(AppDb appDb)
        {
            _appDb = appDb;
        }


        [BindProperty,Required(ErrorMessage ="Please enter the existing username")]
        public string? tbxCurrent_username { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the existing password")]
        public string? tbxCurrent_pw { get; set; }


        [BindProperty, Required(ErrorMessage = "Please enter the new username")]
        public string? tbxNew_username { get; set; }

        [BindProperty, Required(ErrorMessage = "Please enter the new password")]
        public string? tbxNew_pw { get; set; }

        public TblLogin? TblLogin { get; set; }



        public IActionResult OnPost()
        {
            TblLogin = _appDb.TblLogins.Find(tbxCurrent_username);

            return Page();
        }
    }
}
