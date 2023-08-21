using Microsoft.EntityFrameworkCore;
using DockerAPI.Models;

namespace DockerAPI.Context;

public class TesteDbContext : DbContext
{
    public TesteDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("HOST=localhost;PORT=9876;DATABASE=postgres;USER ID=rei;PASSWORD=teste");
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Jogo> Jogos { get; set; }
}
