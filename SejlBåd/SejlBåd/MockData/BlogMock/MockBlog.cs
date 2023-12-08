using System.Reflection.Metadata;

namespace SejlBåd.MockData.BlogMockData
{
    public class MockBlog
    {
        private static List<Models.Blog> blogPostList = new List<Models.Blog>()
        {
            new Models.Blog("Title1", "Desc1", "Text1"),
            new Models.Blog("Title2", "Desc2", "Text2"),
            new Models.Blog("Title3", "Desc3", "Text3")
        };

        public static List<Models.Blog> GetBlogPosts()
        {
            return blogPostList;
        }
    }
}
