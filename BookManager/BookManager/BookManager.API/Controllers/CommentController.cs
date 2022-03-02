using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("[Controller]/api")]
    public class CommentController : ControllerBase
    {

        private readonly ICommentInterface _commentInterface;
        public CommentController(ICommentInterface commentinterface)
        {
            this._commentInterface = commentinterface;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentResponseModel>>> GetComments()
        {
            try
            {
                var result = await _commentInterface.GetComments();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }

        [HttpPost("answer/post")]
        public async Task<ActionResult<AddCommentResponse>> AddAnswerToComment(AddAnswerToCommentRequest req)
        {
            try
            {
                var result = await _commentInterface.AddAnswerToComment(req);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
