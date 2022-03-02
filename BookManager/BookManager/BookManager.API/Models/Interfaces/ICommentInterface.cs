using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Interfaces
{
    public interface ICommentInterface
    {
        public Task<AddCommentResponse> AddComment(AddCommentRequest req);
        public Task<AddCommentResponse> AddAnswerToComment(AddAnswerToCommentRequest req);

        public Task<IEnumerable<CommentResponseModel>> GetComments();
    }
}
