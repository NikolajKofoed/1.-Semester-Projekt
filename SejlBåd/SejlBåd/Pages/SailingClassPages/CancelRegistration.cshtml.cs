using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class CancelRegistrationModel : PageModel
    {
        ISailingClassService _sailingClassService;
        [BindProperty] 
        public Models.User UserToClass { get; set; }

        public CancelRegistrationModel(ISailingClassService sailingClassService)
        {
            _sailingClassService = sailingClassService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
        _sailingClassService.CancelUserToJuniorClass(UserToClass);
            return RedirectToPage("SCReceipt");
        }
    }
}
