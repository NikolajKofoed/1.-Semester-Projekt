using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class RegistreSailingClassModel : PageModel
    {
        private ISailingClassService _sailingClassService;
        [BindProperty]
        public Models.User UserToClass { get; set; }
        
       


        public RegistreSailingClassModel(ISailingClassService sailingClassService)
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
            _sailingClassService.AddUserToJuniorClass(UserToClass);
            return RedirectToPage("GetAllSailingClasses");
        }
       
    }
}
