using BookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMVC.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet <Book> Books { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {

        }
    }
}
