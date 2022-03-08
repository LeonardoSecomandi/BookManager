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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryInterface _categoryService;
        public CategoryController(ICategoryInterface categorys)
        {
            this._categoryService = categorys;
        }

        [HttpPost]
        public async Task<ActionResult<AddCategoryResponse>> AddCategory(Categories category)
        {
            try
            {
                var result = await _categoryService.AddCategory(category);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Errore nel recupero dati dal database");
            }
        }

    }
}
