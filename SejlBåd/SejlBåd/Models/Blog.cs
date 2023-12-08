using Microsoft.AspNetCore.Mvc;

namespace SejlBåd.Models
{
    public class Blog
    {
        private static int nextId = 0;
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string BlogPostTitle { get; set; }
        [BindProperty]
        public string BlogPostSubtext { get; set; }
        [BindProperty]
        public string BlogPostText { get; set; }

        public Blog(string blogTitle, string blogDescription, string blogText)
        {
            Id = nextId++;
            BlogPostTitle = blogTitle;
            BlogPostSubtext = blogDescription;
            BlogPostText = blogText;
        }

        public Blog()
        {
            Id = nextId++;
            BlogPostTitle = "Placeholder Post Title";
            BlogPostSubtext = "Placeholder Description";
            BlogPostText = "Placeholder Post Text";
        }
    }
}
