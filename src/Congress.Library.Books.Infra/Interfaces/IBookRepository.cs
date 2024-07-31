using Congress.Library.Books.Infra.Entities;

namespace Congress.Library.Books.Infra.Interfaces
{
    public interface IBookRepository
    {
        public Task<string> AddBook(BooksDTO request);
    }
}
