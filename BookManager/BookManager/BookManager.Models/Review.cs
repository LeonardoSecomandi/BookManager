using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int ReviewStars { get; set; }

        [Required]
        public string ReviewContent { get; set; }

        [Required]
        public DateTime ReviewPublishDate { get; set; }

        public Ratings Rating { get; set; }
    }
}
