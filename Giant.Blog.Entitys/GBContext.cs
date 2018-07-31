using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class GBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public GBContext(DbContextOptions<GBContext> option)
            : base(option)
        {

        }
    }
}
