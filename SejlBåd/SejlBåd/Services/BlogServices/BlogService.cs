using SejlBåd.Models;

namespace SejlBåd.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private List<Models.Blog> _posts = MockData.BlogMockData.MockBlog.GetBlogPosts();
        private Blog Blog { get; set; }
        private JsonFileBlogService _jsonBlogService;


        private int NextBlogId()
        {
            var maxId = 0;
            foreach (var blog in _posts)
            {
                if (maxId < blog.Id)
                    maxId = blog.Id;
            }
            return maxId + 1;
        }

        public BlogService(JsonFileBlogService jsonBlogService)
        {
            _jsonBlogService = jsonBlogService;
            _posts = _jsonBlogService.GetJsonBlogData().ToList();
        }
        public List<Blog> GetBlogPosts()
        {
            var reversePosts = new List<Blog>();
            for (var i = _posts.Count - 1; i >= 0; i--)
            {
                reversePosts.Add(_posts[i]);
            }

            return reversePosts;
        }

        public void AddBlogPost(Blog blog)
        {
            blog.Id = NextBlogId();
            blog.DatePublished = DateTime.Now;
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
                        i.BlogPostText = blog.BlogPostText;
                    }
                }
                _jsonBlogService.SaveJsonBlogData(_posts);
            }
        }

        public Blog GetBlogPost(int blogId)
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

        public List<Comment> GetCommentsForBlogPost(int blogId)
        {
            var blog = GetBlogPost(blogId);
            return blog?.Comments;

        }

        public void AddCommentToBlog(int blogId, Comment comment)
        {
            var blog = GetBlogPost(blogId);

            if (blog != null)
            {
                comment.Id = Comment.nextId++;
                blog.Comments ??= new List<Comment>();
                blog.Comments.Add(comment);
                _jsonBlogService.SaveJsonBlogData(_posts);
            }
        }
    }
}
