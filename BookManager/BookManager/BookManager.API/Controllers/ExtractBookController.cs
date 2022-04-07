using BookManager.API.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookManager.API.Models.Repositories.ExtractBookFromGoogleApi;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("[Controller]/extract")]
    public class ExtractBookController : ControllerBase
    {
        private readonly IExtractBookFromGoogleApi _extractBookFromGoogleApi;
        public ExtractBookController(IExtractBookFromGoogleApi eb)
        {
            this._extractBookFromGoogleApi = eb;
        }

        [HttpPost]
        public async Task<ActionResult<ExtractBookResponse>> ExtractBooksFromLink(string Link)
        {
            try
            {
                var result = await _extractBookFromGoogleApi.ExtractBooksFromLink(Link);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
