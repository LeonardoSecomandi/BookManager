using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BookManager.Models
{
    public class Book
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public string Titolo { get; set; }

        List<string> Authors { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Identifiers> IndustryIdentifiers { get; set; }
        
        [Required]
        public int PageCount { get; set; }

        public List<Categories> Categories { get; set; }
        
        [Required]
        public string MaturityRating { get; set; }

        [Required]
        public string ContentVersion { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]
        public string Language { get; set; }

    }
}
