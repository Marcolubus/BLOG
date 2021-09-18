using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLOG_MODELS.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "title is required")]

        [MinLength(10, ErrorMessage = "Must be at least 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]

        [MinLength(300, ErrorMessage = "Must be at least 300-5000")]
        [MaxLength(5000, ErrorMessage = "Must be at least 300-5000")]


        public string Content { get; set; }

        public int PhotoId { get; set; }
    }
}
