using Desafio_Mind_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Mind_CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }

    }
}
