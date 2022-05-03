using BookManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.WEB.Models.DTOS.Requests
{
    public class AddCommentRequest
    {
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
