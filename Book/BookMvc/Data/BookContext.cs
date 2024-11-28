using BookMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMvc.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
    }
}
