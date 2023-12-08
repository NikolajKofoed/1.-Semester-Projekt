using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class GetSailingCLassJuniorsModel : PageModel
    {
        private ISailingClassService _sailingClassService;

        [BindProperty] public List<User> JuniorSC { get; set; }
        [BindProperty] public List<User> SeniorSC { get; set; }
        public GetSailingCLassJuniorsModel(ISailingClassService sailingClassService)
        {
            _sailingClassService = sailingClassService;
        }
        public IActionResult OnGet()
        {
            SeniorSC = _sailingClassService.GetSailingClassSenior();
            JuniorSC = _sailingClassService.GetSailingClassJunior();
            return Page();
        }
    }
}
