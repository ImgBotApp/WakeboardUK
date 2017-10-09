using System;
using System.ComponentModel.DataAnnotations;

namespace WakeboardUK.Web.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public string ImageUrl { get; set; }
    }
}