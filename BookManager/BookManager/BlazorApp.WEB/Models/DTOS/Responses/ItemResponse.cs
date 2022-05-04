using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.WEB.Models.DTOS.Responses
{
    public class ItemResponse
    {
        public int ItemId { get; set; }
        public Book Book { get; set; }
        public List<Review> ItemReviewList { get; set; }
        public List<Discussion> ItemDiscussionList { get; set; }
    }
}
