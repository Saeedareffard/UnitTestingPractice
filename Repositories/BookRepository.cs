using Microsoft.EntityFrameworkCore;
using UnitTestingPractice.Models;
using UnitTestingPractice.Repositories.Interfaces;

namespace UnitTestingPractice.Repositories;

public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }

    public Task<Book> GetById(string id)
    {
        return _context.Books.Where(e => e.Id == id).FirstAsync();
    }

    public async Task<Book?> GetByName(string name)
    {
        return await _context.Books.Where(e => e.Name == name).FirstOrDefaultAsync();
    }

    public async Task<Book> CreateBook(Book book)
    {
        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
        return (await _context.Books.Where(e => e.Id == book.Id).FirstAsync())!;
    }
}