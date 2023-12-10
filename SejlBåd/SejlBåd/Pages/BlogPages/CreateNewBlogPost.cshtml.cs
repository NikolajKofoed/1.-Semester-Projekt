using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class CreateNewBlogPostModel : PageModel
    {
        private IBlogService _blogService;
        [BindProperty]
        public Models.Blog BlogPost { get; set; }

        public CreateNewBlogPostModel(IBlogService blogService)
        {
            _blogService = blogService;
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
            _blogService.AddBlogPost(BlogPost);
            return RedirectToPage("GetAllBlogPosts");
        }
    }
}
