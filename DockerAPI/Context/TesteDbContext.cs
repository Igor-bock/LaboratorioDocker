using Microsoft.EntityFrameworkCore;

namespace DockerAPI.Context;

public class TesteDbContext : DbContext
{
    public TesteDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("HOST=10.0.0.86;PORT=5435;DATABASE=temporario;USER ID=docker_user;PASSWORD=docker_user");
    }

    public DbSet<Produto> Produtos { get; set; }
}
