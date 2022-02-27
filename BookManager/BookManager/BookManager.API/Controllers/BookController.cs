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
    public class BookController:ControllerBase
    {
        private readonly IBookRepositoryInterface _bookRepositoryService;

        public BookController(IBookRepositoryInterface bookService)
        {
            this._bookRepositoryService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookResponseModel>>> GetBooks()
        {
            try
            {
                var result = await _bookRepositoryService.GetBooks();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }

        }
    }
}
