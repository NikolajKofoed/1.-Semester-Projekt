using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class RegistreSailingClassModel : PageModel
    {
        private SailingClassService _sailingClassService;
        [BindProperty]
        public Models.User UserToClass { get; set; }
        [BindProperty]
        public string Email { get; set; }


        public RegistreSailingClassModel(SailingClassService sailingClassService)
        {
            _sailingClassService = sailingClassService;
        }

        public IActionResult OnGet()
        {
            UserToClass = _sailingClassService.GetUser(Email);
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
