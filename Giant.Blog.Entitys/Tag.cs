using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Giant.Blog.Entitys
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Tag : BaseEntity
    {
        public int BlogId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        [MaxLength(100), Required]
        public string Name { get; set; }
    }
}
