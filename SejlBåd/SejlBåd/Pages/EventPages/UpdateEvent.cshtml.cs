using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Repositories;

namespace SejlBåd.Pages.EventPages
{
    public class UpdateEventModel : PageModel
    {
        [BindProperty] public UpdateEventModel Event { get; set; }
        public void OnGet()
        {
        }
    }
}
