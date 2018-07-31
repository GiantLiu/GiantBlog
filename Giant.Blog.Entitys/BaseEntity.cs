using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Giant.Blog.Entitys
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
