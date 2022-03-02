using BookManager.API.Data;
using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using BookManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Repositories
{
    public class CommentRepository : ICommentInterface
    {
        private readonly ApplicationDbContext _context;
        public CommentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<AddCommentResponse> AddComment(AddCommentRequest req)
        {
            var result = await _context.AddAsync(new Comment() {
                CommentContent = req.CommentContent,
                Answers = null,
                DownVotes = 0,
                UpVotes = 0,
                UserId = req.UserId
            });
            await _context.SaveChangesAsync();
            return new AddCommentResponse()
            {
                Success = true,
                Message = "Commento Aggiunto",
                Errors = null,
                AddedComment = result.Entity,
            };

        }

        public async Task<AddCommentResponse> AddAnswerToComment(AddAnswerToCommentRequest req)
        {
            var AnswerComment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == req.IdCommentAnswer);
            if (AnswerComment is null)
                return new AddCommentResponse()
                {
                    Success = false,
                    AddedComment = null,
                    Message = "Errore nell'aggiunta della risposta",
                    Errors = null
                };

            var result = await _context.AddAsync(new Comment() {
                CommentContent=req.CommentContent,
                AnswerCommentId=req.IdCommentAnswer,
                Answers=null,
                DownVotes=0,
                UpVotes=0,
                UserId=req.UserId
            });
            await _context.SaveChangesAsync();
            return new AddCommentResponse()
            {
                Success = true,
                Message = "Risposta aggiunta",
                AddedComment = result.Entity,
                Errors = null
            };
        }

        public async Task<IEnumerable<CommentResponseModel>> GetComments()
        {
            var result = await _context.Comments.ToListAsync();
            var EleComments = new List<CommentResponseModel>();
            foreach(var Comment in result)
            {
                var Answers = await _context.Comments.Where(ac => ac.AnswerCommentId == Comment.Id).ToListAsync();
                EleComments.Add(new CommentResponseModel()
                {
                    Success = true,
                    Message = "Commento Ricevuto",
                    Errors = null,
                    Comment = Comment,
                    Asnwers=Answers
                });
            }
            return EleComments;
        }
    }
}
