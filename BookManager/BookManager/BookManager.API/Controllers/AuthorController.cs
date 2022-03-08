using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.API.Models.Interfaces;
using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;
using Microsoft.AspNetCore.Http;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("[Controller]/api")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorInterface _authorInterface;
        public AuthorController(IAuthorInterface authorservice)
        {
            this._authorInterface = authorservice;
        }

        [HttpPost]
        public async Task<ActionResult<AddAuthorResponse>> AddAuthor(Author author)
        {
            try
            {
                var result = await _authorInterface.AddAuthor(author);
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
