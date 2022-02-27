using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public string AuthorName { get; set; }
    }
}
