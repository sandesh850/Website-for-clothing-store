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
            TblLogin = _appDb.TblLogins.FirstOrDefault(x => x.Username == tbxCurrent_username);

            var currentUseNm = "";
            var currentPW = "";
 
            if(TblLogin != null)
            {
                currentUseNm = TblLogin.Username;
                currentPW = TblLogin.Password;

            }

            if(HttpContext.Session.GetString("LoginChecking") != "true")
            {
                if (currentUseNm.Equals(tbxCurrent_username) && currentPW == tbxCurrent_pw)
                {

                    HttpContext.Session.SetString("LoginChecking", "true");
                }
            }
            else if(HttpContext.Session.GetString("LoginChecking") == "true")
            {
                _appDb.TblLogins.Remove(TblLogin);
                _appDb.SaveChanges();

                TblLogin tblLogin = new TblLogin
                {
                    Username = tbxNew_username,
                    Password = tbxNew_pw

                };
                _appDb.TblLogins.Update(tblLogin);
                _appDb.SaveChanges();
            }





            return Page();
        }
    }
}
