using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Congress.Library.Books.Infra.Entities;
using Congress.Library.Books.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congress.Library.Books.Infra
{  
    public class BookRepository : IBookRepository
    {
        private readonly DynamoDBContext _context;
        public BookRepository(IAmazonDynamoDB dynamoDbClient)
        {
            _context = new DynamoDBContext(dynamoDbClient);
        }

        public async Task<string> AddBook(BooksDTO request)
        {
            var dateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Standard Time"));
            var uuid = Guid.NewGuid().ToString();

            var newBookRequest = new BooksDTO
            {
                Id = uuid,
                Title = request.Title,
                Author = request.Author,
                Description = request.Description,
                Genre = request.Genre,
                Version = request.Version
            };

            await _context.SaveAsync(newBookRequest);

            return "path";
        }
    }
}
