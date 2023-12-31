﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Post>? Post { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
