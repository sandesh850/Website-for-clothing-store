using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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


        //public async Task<IActionResult> OnPostAsync()
        //{
        //    return Page();
        //}

        public void OnGet()
        {
        }
    }
}
