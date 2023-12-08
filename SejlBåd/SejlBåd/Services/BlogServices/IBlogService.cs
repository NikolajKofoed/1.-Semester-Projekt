﻿using SejlBåd.Models;

namespace SejlBåd.Services.BlogServices
{
    public interface IBlogService
    {
        List<Blog> GetBlogPosts();
        void AddBlogPost(Blog blog);
        void UpdateBlogPost(Blog blog);
        Blog GetBlogPost(int blogId);
        Blog DeleteBlogPost(int? blogId);
    }
}
