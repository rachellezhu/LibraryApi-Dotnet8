using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models;

public class AuthorContext : DbContext
{
    public AuthorContext(DbContextOptions<AuthorContext> options) : base(options) 
    {

    }

    public DbSet<Author> Authors { get; set; } = null;
}