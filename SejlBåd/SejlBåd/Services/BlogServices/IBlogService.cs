using SejlBåd.Models;

namespace SejlBåd.Services.BlogServices
{
    public interface IBlogService
    {
        //Blog Methods START
        List<Blog> GetBlogPosts();
        void AddBlogPost(Blog blog);
        void UpdateBlogPost(Blog blog);
        public Blog GetBlogPost(int blogId);
        Blog DeleteBlogPost(int? blogId);
        //Blog Methods STOP
        List<Comment> GetCommentsForBlogPost(int blogId);
        void AddCommentToBlog(int blogId, Comment comment);
        void GetCurrentDate();
    }
}
