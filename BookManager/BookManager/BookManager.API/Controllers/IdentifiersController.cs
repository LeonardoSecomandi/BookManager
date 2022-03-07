using BookManager.API.Models.DTOS.Responses;
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
    public class IdentifiersController : ControllerBase
    {

        private readonly IidentifierInterface iidentifierService;
        public IdentifiersController(IidentifierInterface iidentifier)
        {
            this.iidentifierService = iidentifier;
        }


        [HttpPost]
        public async Task<ActionResult<AddIdentifierResponse>> AddIdentifier(Identifiers identifiers)
        {
            try
            {
                var result = await iidentifierService.AddIdentifier(identifiers);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }
    }
}
