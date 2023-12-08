using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BlogServices;

namespace SejlBåd.Pages.BlogPages
{
    public class GetAllBlogPostsModel : PageModel
    {
        public IBlogService _blogService { get; set; }
        public List<Blog> blogPosts { get; set; }
        public List<Comment> Comments { get; set; }
        [BindProperty]
        public Comment NewComment { get; set; }

        public GetAllBlogPostsModel(IBlogService blogService)
        {
            this._blogService = blogService;
        }

        public void OnGet()
        {
            blogPosts = _blogService.GetBlogPosts();
            //Comments = _blogService.GetCommentsForBlogPost(blogId);
        }

        //public IActionResult OnPostAddComment(int blogId)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _blogService.AddCommentToBlog(blogId, NewComment);
        //    return RedirectToPage("GetAllBlogPosts");
        //}
    }
}
