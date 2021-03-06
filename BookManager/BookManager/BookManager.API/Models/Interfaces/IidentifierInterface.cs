using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Interfaces
{
    public interface IidentifierInterface
    {
        public Task<AddIdentifierResponse> AddIdentifier(Identifiers identifiers);
    }
}
