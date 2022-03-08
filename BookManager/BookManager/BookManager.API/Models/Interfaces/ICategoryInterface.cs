using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Interfaces
{
    public interface ICategoryInterface
    {
        public Task<AddCategoryResponse> AddCategory(Categories category);
    }
}
