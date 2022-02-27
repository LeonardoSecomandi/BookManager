using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookManager.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [JsonIgnore]
        public Book Book { get; set; }

        [Required]
        public string AuthorName { get; set; }
    }
}
