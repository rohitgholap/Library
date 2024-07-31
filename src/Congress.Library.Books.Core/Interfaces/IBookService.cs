using Congress.Library.Books.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congress.Library.Books.Core.Interfaces
{
    public interface IBookService
    {
        public Task<string> AddBook(NewBook newBook);
        public Task<string> UpdateBook(UpdateBook updateBook);
        public Task<string> RetrieveBook(string id);
    }
}
