using CodeFirst.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models.BusinessModels
{
    public class BookManagementContext : DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options): base(options)
        {
        }

        // Khai báo các tập thực thể (bảng)
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
