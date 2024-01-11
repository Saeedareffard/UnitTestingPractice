using UnitTestingPractice.Models;

namespace UnitTestingPractice.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public Task<Book> CreateBook(Book book);
        public Task<List<Book>> GetBooks();
        public Task<Book?> GetById(string id);
        public Task<Book?> GetByName(string name);

    }
}
