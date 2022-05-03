using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.WEB.Models.DTOS.Requests
{
    public class AddBookRequest
    {
        [Required]
        public Book Book { get; set; }
    }
}
