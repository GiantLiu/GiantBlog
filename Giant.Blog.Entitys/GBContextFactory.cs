using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class GBContextFactory : IDesignTimeDbContextFactory<GBContext>
    {
        public GBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GBContext>();
            optionsBuilder.UseSqlServer("data source=192.168.1.205;initial catalog=GiantBlog;persist security info=True;user id=hcsy;password=it@hcsy@123456;MultipleActiveResultSets=True;App=GB");
            return new GBContext(optionsBuilder.Options);
        }
    }
}
