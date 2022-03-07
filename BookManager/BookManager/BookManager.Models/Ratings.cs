using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManager.Models
{
    public class Ratings
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int RatingValue { get; set; }

        [Required]
        public DateTime RatingDate { get; set; }
    }
}
