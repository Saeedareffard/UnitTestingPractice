using Microsoft.EntityFrameworkCore;
using UnitTestingPractice.Models;

namespace UnitTestingPractice;

public class ApplicationDbContext : DbContext
{
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }
}

public static class DIExtension
{
    public static IServiceCollection AddDbConfig(this IServiceCollection services)
    {
        return services.AddDbContext<ApplicationDbContext>
            (options => options.UseInMemoryDatabase("BookDb"));
    }
}