﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.WEb.Models.DTOS.Responses;

namespace BookManager.Web.Models.DTOS.Responses
{
    public class BookResponseModel : BaseResponse
    {
        public Book Book { get; set; }
        public double RatingsAverage { get; set; }
        //public double RatingAverage { get; set; }
        //public Author Author { get; set; }
        //public Categories Categories { get; set; }
        //public Identifiers Identifiers { get; set; }
    }
}
