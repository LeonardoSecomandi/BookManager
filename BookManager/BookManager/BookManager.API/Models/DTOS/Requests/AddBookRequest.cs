using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.API.Models.DTOS.Requests
{
    public class AddBookRequest
    {
        [Required]
        public Book Book { get; set; }

        [Required]
        public List<Identifiers> Identifiers { get; set; }

        [Required]
        public List<Author> Author { get; set; }

        [Required]
        public List<Categories> Categories { get;set; }

    }
}
