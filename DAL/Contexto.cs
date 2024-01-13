using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class Contexto :DbContext
{
    public DbSet<Prioridades> prioridades {get ; set; }
    public Contexto(DbContextOptions<Contexto> options):base(options) 
    {
        
    }
}