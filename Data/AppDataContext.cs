
using Microsoft.EntityFrameworkCore;
using LojaApi.Models;

namespace LojaApi.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Produto>().ToTable("Produtos");
        modelBuilder.Entity<Models.Categoria>().ToTable("Categorias");
    }
}
