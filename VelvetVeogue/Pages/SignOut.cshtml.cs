using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VelvetVeogue.Pages
{
    public class SignOutModel : PageModel
    {
        public IActionResult OnGet()
        {

            HttpContext.Session.Clear();

            return RedirectToPage("/index");
        }
    }
}
