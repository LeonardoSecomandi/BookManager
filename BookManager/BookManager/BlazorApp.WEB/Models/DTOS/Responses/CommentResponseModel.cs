using BookManager.Models;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.WEB.Models.DTOS.Responses
{
    public class CommentResponseModel : BaseResponse
    {
        public Comment Comment { get; set; }
        public List<Comment> Asnwers { get; set; }
    }
}
