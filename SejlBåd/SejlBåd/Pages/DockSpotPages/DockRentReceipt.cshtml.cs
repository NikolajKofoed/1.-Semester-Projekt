using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class DockRentReceiptModel : PageModel
    {
        private IDockSpotService _dockSpotService;
        [BindProperty] public Order Order { get; set; }

        public DockRentReceiptModel(IDockSpotService dockSpotService)
        {
            _dockSpotService = dockSpotService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
