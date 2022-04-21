using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.API;
using BookManager.Models;

namespace BookManager.API.Models.DTOS.Responses
{
    public class ItemResponse
    {
        public Book Book { get; set; }
        public List<Review> ItemReviewList { get; set; }
        public List<Discussion> ItemDiscussionList { get; set; }
    }
}
