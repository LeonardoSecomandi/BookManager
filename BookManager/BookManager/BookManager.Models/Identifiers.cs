using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManager.Models
{
    public class Identifiers
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Indentifier { get; set; }
    }
}
