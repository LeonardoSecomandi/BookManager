using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using BookManager.API.Models.Repositories;
using BookManager.Models;
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
    [Route("[Controller]/api")]
    public class BookController:ControllerBase
    {
        private readonly IBookRepositoryInterface _bookRepositoryService;

        public BookController(IBookRepositoryInterface bookService,
            IExtractBookFromGoogleApi bookFromGoogleApi)
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
        [HttpGet("book/{id:int}")]
        public async Task<ActionResult<BookResponseModel>> GetBookById(int id)
        {
            try
            {
                var result = await _bookRepositoryService.GetBookById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<AddBookResponse>> AddBook(AddBookRequest req)
        {
            try
            {
                var result = await _bookRepositoryService.AddBook(req);
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }

        [HttpGet("savedbooks")]
        public async Task<ActionResult<IEnumerable<Book>>>GetSavedBooks(string UserId)
        {
            try
            {
                var Books = await _bookRepositoryService.GetUserSavedBooks(UserId);
                return Ok(Books);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }

        [HttpPost("addtofavourites")]
        public async Task<ActionResult<SavedBooks>> AddBookToFavourites(AddBookTOFavouireRequest req)
        {
            try
            {
                var Result = await _bookRepositoryService.AddBookToFavourites(req);
                return Result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
