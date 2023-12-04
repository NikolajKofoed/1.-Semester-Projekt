using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;

namespace SejlBåd.Pages.SailingClassPages
{
    public class GetAllSailingClassesModel : PageModel
    {

        public List<Models.SailingClass> sailingClasses { get; private set; }

        [BindProperty] public string ClassName { get; set; }

        public GetAllSailingClassesModel()
        {
        }
        public void OnGet()
        {
        }
    }
}
