using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.API.Models.DTOS.Responses
{
    public class BookResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public Book Book { get; set; }

        //public Author Author { get; set; }
        //public Categories Categories { get; set; }
        //public Identifiers Identifiers { get; set; }
    }
}
