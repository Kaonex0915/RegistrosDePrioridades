using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class Contexto :DbContext
{
    public DbSet<Prioridades> prioridades {get ; set; }
    public DbSet<Clientes> clientes {get ; set; }

    public DbSet<Tickets> tickets {get; set;}

    public DbSet<Sistemas> sistemas {get; set;}    

    public Contexto(DbContextOptions<Contexto> options):base(options) 
    {
        
    }
    
}