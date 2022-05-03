using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.WEB.Models.DTOS.Responses
{
    public class AddCommentResponse : BaseResponse
    {
        public Comment AddedComment { get; set; }
    }
}
