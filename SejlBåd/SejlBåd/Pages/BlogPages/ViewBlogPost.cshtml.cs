using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class ViewBlogPostModel : PageModel
    {
        public IBlogService _blogService;
        [BindProperty] public Blog blogs { get; set; }
        public List<Comment> Comments { get; set; }
        [BindProperty]
        public Comment NewComment { get; set; }

        public ViewBlogPostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public void OnGet(int id)
        {
            blogs = _blogService.GetBlogPost(id);    
        }
    }
}
