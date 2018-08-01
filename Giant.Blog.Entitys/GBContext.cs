using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class GBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<PostSummary> PostSummary { get; set; }
        public GBContext(DbContextOptions<GBContext> option)
            : base(option)
        {

        }
    }
}
