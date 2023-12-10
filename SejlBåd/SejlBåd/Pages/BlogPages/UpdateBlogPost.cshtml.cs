using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class UpdateBlogPostModel : PageModel
    {
        private IBlogService _blogService;
        [BindProperty]
        public Models.Blog BlogPost { get; set; }

        public UpdateBlogPostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult OnGet(int id)
        {
            BlogPost = _blogService.GetBlogPost(id);
            if (BlogPost == null)
            {
                return RedirectToPage("GetAllBlogPosts");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _blogService.UpdateBlogPost(BlogPost);
            return RedirectToPage("GetAllBlogPosts");
        }
    }
}
