using System.Runtime.CompilerServices;
using UnitTestingPractice.Common;
using UnitTestingPractice.Models;
using UnitTestingPractice.Repositories.Interfaces;
using UnitTestingPractice.Services.Interfaces;

namespace UnitTestingPractice.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<Book> AddBook(Book book)
        {
            if (await _repository.GetByName(book.Name) is not null)
            {
                throw new DuplicateRecordException("There is at least one book with this Name");
            }
            return await _repository.CreateBook(book);
        }

        public Task<List<Book>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteBook(string id)
        {
            throw new NotImplementedException();
        }
    }
}
