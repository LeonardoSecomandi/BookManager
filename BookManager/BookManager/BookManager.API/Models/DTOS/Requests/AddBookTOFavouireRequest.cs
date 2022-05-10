using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.DTOS.Requests
{
    public class AddBookTOFavouireRequest
    {
        [Required]
        public string UserId { get; set; }

        public int BookId { get; set; }
    }
}
