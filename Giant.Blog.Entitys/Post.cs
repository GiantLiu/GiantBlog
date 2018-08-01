using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Giant.Blog.Entitys
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// 所属博客
        /// </summary>
        public int BlogId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(100), Required]
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        [MaxLength(1000)]
        public string Summary { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PushTime { get; set; }
        /// <summary>
        /// 允许评论
        /// </summary>
        public bool AllowComment { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
    }
}
