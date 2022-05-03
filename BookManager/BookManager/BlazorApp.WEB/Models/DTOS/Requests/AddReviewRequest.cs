using BookManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.WEB.Models.DTOS.Requests
{
    public class AddReviewRequest
    {
        [Required]
        public int BookId { get; set; }

        [Required]
        public int ReviewStars { get; set; }

        [Required]
        public string ReviewContent { get; set; }

        [Required]
        public DateTime ReviewPublishDate { get; set; }

        [Required]
        public int UserID { get; set; }

        
    }
}
