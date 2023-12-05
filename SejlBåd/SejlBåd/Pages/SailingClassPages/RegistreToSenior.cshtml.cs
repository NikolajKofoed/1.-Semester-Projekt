using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class RegistreToSeniorModel : PageModel
    {
        private ISailingClassService _sailingClassService;
        [BindProperty]
        public Models.User UserToClass { get; set; }
     

        public RegistreToSeniorModel(ISailingClassService sailingClassService)
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
            _sailingClassService.AddUserToClass(UserToClass);
            return RedirectToPage("GetAllSailingClasses");
        }
    }
}
