using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.SailingClassServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class GetAllSailingClassesModel : PageModel
    {
        private ISailingClassService _sailingClassService;
        public List<SailingClass> sailingClasses { get; private set; }

        [BindProperty] public string ClassName { get; set; }

        public GetAllSailingClassesModel(ISailingClassService sailingClassService)
        {
            _sailingClassService = sailingClassService;
        }
        public void OnGet()
        {
            _sailingClassService.GetSailingClasses();
        }
    }
}
