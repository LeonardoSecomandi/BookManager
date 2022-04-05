using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookManager.API.Models.Repositories.ExtractBookFromGoogleApi;

namespace BookManager.API.Models.Interfaces
{
    public interface IExtractBookFromGoogleApi
    {
        public Task<ExtractBookResponse> ExtractBooksFromLink(string Link);
    }
}
