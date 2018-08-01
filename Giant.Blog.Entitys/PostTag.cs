using System;
using System.Collections.Generic;
using System.Text;

namespace Giant.Blog.Entitys
{
    /// <summary>
    /// 文章标签
    /// </summary>
    public class PostTag : BaseEntity
    {
        public int BlogId { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
