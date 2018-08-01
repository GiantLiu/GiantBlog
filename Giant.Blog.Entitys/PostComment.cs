using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class PostComment : BaseEntity
    {
        public int BlogId { get; set; }
        public int PostId { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [MaxLength(100), Required]
        public string NickName { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        [MaxLength(1000), Required]
        public string Comment { get; set; }
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        [MaxLength(100), Required]
        public string IpAddr { get; set; }

    }
}
