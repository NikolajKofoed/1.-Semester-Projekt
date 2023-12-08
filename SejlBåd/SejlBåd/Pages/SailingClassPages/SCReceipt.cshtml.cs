using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class SCReceiptModel : PageModel
    {
        private ISailingClassService _sailingClassService;
        public List<User> UserToClass { get; set; }

        public SCReceiptModel(ISailingClassService sailingClassService)
        {
            _sailingClassService = sailingClassService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
