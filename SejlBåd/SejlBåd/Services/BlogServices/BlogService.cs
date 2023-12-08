using SejlBåd.Models;

namespace SejlBåd.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private List<Models.Blog> _posts = MockData.BlogMockData.MockBlog.GetBlogPosts();
        private JsonFileBlogService _jsonBlogService;


        public BlogService(JsonFileBlogService jsonBlogService)
        {
            _jsonBlogService = jsonBlogService;
            _posts = _jsonBlogService.GetJsonBlogData().ToList();
        }
        public List<Blog> GetBlogPosts()
        {
            return _posts;
        }

        public void AddBlogPost(Blog blog)
        {
            _posts.Add(blog);
            _jsonBlogService.SaveJsonBlogData(_posts);
        }

        public void UpdateBlogPost(Blog blog)
        {
            if (blog != null)
            {
                foreach (Blog i in _posts)
                {
                    if (i.Id == blog.Id)
                    {
                        i.BlogPostTitle = blog.BlogPostTitle;
                        i.BlogPostSubtext = blog.BlogPostSubtext;
                        i.BlogPostText = blog.BlogPostText;
                    }
                }
                _jsonBlogService.SaveJsonBlogData(_posts);
            }
        }

        Blog IBlogService.GetBlogPost(int blogId)
        {
            foreach (var blog in _posts)
            {
                if (blog.Id == blogId)
                {
                    return blog;
                }
            }
            return null;
        }

        public Blog DeleteBlogPost(int? blogId)
        {
            foreach (var i in _posts)
            {
                if (i.Id == blogId)
                {
                    _posts.Remove(i);
                    _jsonBlogService.SaveJsonBlogData(_posts);
                    break;
                }
            }
            return null;
        }

        //public List<Comment> GetCommentsForBlogPost(int blogId)
        //{
        //    var blog = GetBlogPost(blogId);
        //    return blog?.Comments;

        //}

        //public void AddCommentToBlog(int blogId, Comment comment)
        //{
        //    var blog = GetBlogPost(blogId);

        //    if (blog != null)
        //    {
        //        comment.Id = Comment.nextId++;
        //        blog.Comments ??= new List<Comment>();
        //        blog.Comments.Add(comment);
        //        _jsonBlogService.SaveJsonBlogData(_posts);
        //    }
        //}
    }
}
