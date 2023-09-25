using Microsoft.EntityFrameworkCore;

public class EstacionamentoDbContext : DbContext
{
    public DbSet<Veiculo>? veiculo {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "DataSource=estacionamento.db;Cache=Shared");
    }
}