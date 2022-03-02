using BookManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.DTOS.Requests
{
    public class AddAnswerToCommentRequest
    {
        [Required]
        public int IdCommentAnswer { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string CommentContent { get; set; }

        [Required]
        public int UpVotes { get; set; }

        [Required]
        public int DownVotes { get; set; }
    }
}
