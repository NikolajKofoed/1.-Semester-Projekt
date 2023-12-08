using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class DeleteBlogPostModel : PageModel
    {
        private IBlogService _blogService;
        [BindProperty]
        public Models.Blog BlogPosts { get; set; }

        public DeleteBlogPostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult OnGet(int id)
        {
            BlogPosts = _blogService.GetBlogPost(id);
            if (BlogPosts == null)
            {
                return RedirectToPage("GetAllBlogPosts");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Models.Blog deletedBlogPost = _blogService.DeleteBlogPost(BlogPosts.Id);
            if (deletedBlogPost == null)
            {
                return RedirectToPage("GetAllBlogPosts");
            }
            return Page();
        }
    }
}
