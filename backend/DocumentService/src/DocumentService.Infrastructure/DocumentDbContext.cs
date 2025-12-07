using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Document = DocumentService.Domain.Document;

namespace DocumentService.Infrastructure;

public class DocumentDbContext : DbContext
{
    private readonly DbContext _dbContext;

    public DocumentDbContext(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public DbSet<Document> Documents => Set<Document>();
}