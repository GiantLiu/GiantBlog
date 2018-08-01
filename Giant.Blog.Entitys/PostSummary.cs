using System;
using System.Collections.Generic;
using System.Text;

namespace Giant.Blog.Entitys
{
    /// <summary>
    /// 文章统计
    /// </summary>
    public class PostSummary : BaseEntity
    {
        public int BlogId { get; set; }
        public int PostId { get; set; }
        /// <summary>
        /// 查看次数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 评论次数
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// 点赞次数
        /// </summary>
        public int StarCount { get; set; }

    }
}
