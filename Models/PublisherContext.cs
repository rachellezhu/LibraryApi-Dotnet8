using Microsoft.EntityFrameworkCore;
using LibraryApi.Models;

namespace LibraryApi.Models;

public class PublisherContext : DbContext
{
    public PublisherContext(DbContextOptions<PublisherContext> options) : base(options)
    {
        
    }

public DbSet<LibraryApi.Models.Publisher> Publisher { get; set; } = default!;
}