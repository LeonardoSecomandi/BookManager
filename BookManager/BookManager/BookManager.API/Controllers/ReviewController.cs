using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.Interfaces;
using BookManager.Models;
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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewInterface _reviewService;

        public ReviewController(IReviewInterface review)
        {
            this._reviewService = review;
        }

        [HttpPost]
        public async Task<ActionResult<Review>> AddReview(AddReviewRequest req)
        {
            try
            {
                var result = await _reviewService.AddReview(req);
                if (result != null)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
