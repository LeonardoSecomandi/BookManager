using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Discussion
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public string DiscussionTitle { get; set; }

        public List<Comment> DiscussionComments { get; set; }

        [Required]
        public string DiscussionPublishDate { get; set; }

    }
}
