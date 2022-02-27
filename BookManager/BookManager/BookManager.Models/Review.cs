using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Review
    {
        [Key,Required]
        public int id { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int ReviewStars { get; set; }

        [Required]
        public string ReviewCommentId { get; set; }

        [Required]
        public string ReviewPublishDate { get; set; }
    }
}
