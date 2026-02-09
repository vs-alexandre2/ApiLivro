using Microsoft.EntityFrameworkCore;
using ApiLivro.ApiLivro.Domain.Models;

namespace ApiLivro.ApiLivro.Infrastructure.DataContexts
{
    public class LivroDbContext : DbContext
    {
       
        public LivroDbContext(DbContextOptions<LivroDbContext> options) : base(options)
        {
        }

        public DbSet<LivroModel> Livros { get; set; }
        
    }
}
