using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VelvetVeogue.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public string? tbxusername { get; set; } 

        [BindProperty]
        public string? tbxpassword { get; set; }


        [BindProperty]
        public string? tbxConfirmpassword { get; set; } 


        public IActionResult OnPost()
        {

            if(tbxusername == "Username")
            {
                tbxpassword = "Error";
                
                return Page();
            }

            return Page();
        }

        public void OnGet()
        {
        }
    }
}
