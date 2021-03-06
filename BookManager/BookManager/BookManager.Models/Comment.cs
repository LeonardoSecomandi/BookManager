using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Comment
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string CommentContent { get; set; }

        [Required]
        public int UpVotes { get; set; }

        [Required]
        public int DownVotes { get; set; }

        public List<Comment> Answers { get; set; }
        public int AnswerCommentId { get; set; }
    }
}
