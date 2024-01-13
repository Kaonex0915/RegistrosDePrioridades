using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

public class PrioridadesBLL{
    private Contexto _contexto; 
    
    public PrioridadesBLL(Contexto contexto)
    {
        _contexto = contexto;

    }

    public bool Existe(int Id){
        return _contexto.prioridades.Any(p => p.PrioridadId == Id);
    }

    public bool Insertar(Prioridades prioridades){
        _contexto.prioridades.Add(prioridades);
        var insertado = _contexto.SaveChanges();
        return insertado > 0;
        }

        public bool Modificar(Prioridades prioridades){
        _contexto.prioridades.Update(prioridades);
        var modificado = _contexto.SaveChanges();
        return modificado > 0;
        }

        public bool Guardar(Prioridades prioridades){
            if (!Existe(prioridades.PrioridadId) ){
                return Insertar(prioridades);                
            } 
            else {
                return Modificar(prioridades);
            }
        }

        public bool Eliminar(Prioridades prioridades){
        _contexto.prioridades.Remove(prioridades);
        var eliminado = _contexto.SaveChanges();
        return eliminado > 0;
        }


        public Prioridades? Buscar(int Id){
            return _contexto.prioridades
            .AsNoTracking()
            .SingleOrDefault(p => p.PrioridadId == Id);
        }

        public List<Prioridades> Listar(Expression<Func<Prioridades, bool>> Criterio){
            return _contexto.prioridades
            .Where(Criterio)
            .AsNoTracking()
            .ToList();

        }
}