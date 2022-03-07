using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.API.Models.DTOS.Responses
{
    public class AddIdentifierResponse : BaseResponse
    {
        public Identifiers AddedIdentifier { get; set; }
    }
}
