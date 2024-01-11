using UnitTestingPractice.Models;

namespace UnitTestingPractice.Services.Interfaces
{
    public interface IBookService
    {
        public Task<Book> AddBook(Book book);

        public Task<List<Book>> GetBooks();

        public Task<string> DeleteBook(string id);
    }
}
