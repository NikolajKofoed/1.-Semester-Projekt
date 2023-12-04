using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Repositories;

namespace SejlBåd.Pages.EventPages
{
    public class UpdateEventModel : PageModel
    {
        [BindProperty] public Event Event { get; set; }

        public UpdateEventModel( )
        {

        }
        public void OnGet()
        {

        }
    }
}
