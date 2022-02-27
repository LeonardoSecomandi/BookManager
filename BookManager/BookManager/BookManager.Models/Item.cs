﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookId { get; set; }

       public List<Review> ItemReviewList { get; set; }


        
        ///lista discussioni
        ///

       
    }
}
