using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class Blog : BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(100), Required]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [MaxLength(100), Required]
        public string Password { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(100), Required]
        public string Name { get; set; }
        /// <summary>
        /// Logo
        /// </summary>
        [MaxLength(1000)]
        public string Logo { get; set; }
        /// <summary>
        /// 公告
        /// </summary>
        [MaxLength(1000)]
        public string Notice { get; set; }
        /// <summary>
        /// 访问域名
        /// </summary>
        [MaxLength(1000)]
        public string Url { get; set; }
        /// <summary>
        /// 自定义域名
        /// </summary>
        [MaxLength(1000)]
        public string CustomUrl { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
