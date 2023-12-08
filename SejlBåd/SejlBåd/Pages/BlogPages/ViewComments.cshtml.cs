using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class ViewCommentsModel : PageModel
    {
        public IBlogService _blogService;

        public List<Comment> Comments { get; set; }

        public ViewCommentsModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public void OnGet(int blogId)
        {
            Comments = _blogService.GetCommentsForBlogPost(blogId);
        }
    }
}
