using Congress.Library.Books.Core.Interfaces;
using Congress.Library.Books.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congress.Library.Books.Core
{
    public class BookService : IBookService
    {
        public async Task<string> AddBook(NewBook newBook)
        {
            throw new NotImplementedException();
            
            //Add Business Logic

            //Add Mapping

            //Call the RepoLayer to get result
        }

        public Task<string> RetrieveBook(string id)
        {
            throw new NotImplementedException();

            //Add Business Logic

            //Add Mapping

            //Call the RepoLayer to get result
        }

        public Task<string> UpdateBook(UpdateBook updateBook)
        {
            throw new NotImplementedException();

            //Add Business Logic

            //Add Mapping

            //Call the RepoLayer to get result
        }
    }
}
