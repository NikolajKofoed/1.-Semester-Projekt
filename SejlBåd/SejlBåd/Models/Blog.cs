using Microsoft.AspNetCore.Mvc;

namespace SejlBåd.Models
{
    public class Blog
    {
        private static int nextId = 1;
        [BindProperty]
        public int Id { get; set; } = 0;
        [BindProperty]
        public string BlogPostTitle { get; set; }
        [BindProperty]
        public string BlogPostText { get; set; }
        [BindProperty]
        public List<Comment> Comments { get; set; }
        [BindProperty]
        public DateTime DatePublished { get; set; }
        public Blog(string blogTitle, string blogDescription, string blogText)
        {
            BlogPostTitle = blogTitle;
            BlogPostText = blogText;
            Comments = new List<Comment>();
        }

        public Blog()
        {
            BlogPostTitle = "Placeholder Post Title";
            BlogPostText = "Placeholder Post Text";
            Comments = new List<Comment>();
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(BlogPostTitle)}={BlogPostTitle}, {nameof(BlogPostText)}={BlogPostText}, {nameof(Comments)}={Comments}, {nameof(DatePublished)}={DatePublished.ToString()}}}";
        }
    }
}
