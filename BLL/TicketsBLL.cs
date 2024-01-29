using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

public class TicketsBLL{
    private Contexto _contexto; 
    
    public TicketsBLL(Contexto contexto)
    {
        _contexto = contexto;

    }

    public bool Existe(int Id){
        return _contexto.tickets.Any(t => t.TicketId == Id);
    }

    public bool Insertar(Tickets tickets){
        _contexto.tickets.Add(tickets);
        var insertado = _contexto.SaveChanges();
        return insertado > 0;
        }

        public bool Modificar(Tickets tickets){
        _contexto.tickets.Update(tickets);
        var modificado = _contexto.SaveChanges();
        return modificado > 0;
        }

        public bool Guardar(Tickets tickets){
            if (!Existe(tickets.TicketId) ){
                return Insertar(tickets);                
            } 
            else {
                return Modificar(tickets);
            }
        }

        public bool Eliminar(Tickets tickets){
        _contexto.tickets.Remove(tickets);
        var eliminado = _contexto.SaveChanges();
        return eliminado > 0;
        }

        public Tickets? Buscar(int Id){
            return _contexto.tickets
            .AsNoTracking()
            .SingleOrDefault(p => p.TicketId == Id);
        }

        public List<Tickets> Listar(Expression<Func<Tickets, bool>> Criterio){
            return _contexto.tickets
            .Where(Criterio)
            .AsNoTracking()
            .ToList();

        }
}
