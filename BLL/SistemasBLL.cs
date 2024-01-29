using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

public class SistemasBLL{
    private Contexto _contexto; 
    
    public SistemasBLL(Contexto contexto)
    {
        _contexto = contexto;

    }

    public bool Existe(int Id){
        return _contexto.sistemas.Any(s => s.SistemaId == Id);
    }

    public bool Insertar(Sistemas sistemas){
        _contexto.sistemas.Add(sistemas);
        var insertado = _contexto.SaveChanges();
        return insertado > 0;
        }

        public bool Modificar(Sistemas sistemas){
        _contexto.sistemas.Update(sistemas);
        var modificado = _contexto.SaveChanges();
        return modificado > 0;
        }

        public bool Guardar(Sistemas sistemas){
            if (!Existe(sistemas.SistemaId) ){
                return Insertar(sistemas);                
            } 
            else {
                return Modificar(sistemas);
            }
        }

        public bool Eliminar(Sistemas sistemas){
        _contexto.sistemas.Remove(sistemas);
        var eliminado = _contexto.SaveChanges();
        return eliminado > 0;
        }


        public Sistemas? Buscar(int Id){
            return _contexto.sistemas
            .AsNoTracking()
            .SingleOrDefault(s => s.SistemaId == Id);
        }

        public List<Sistemas> Listar(Expression<Func<Sistemas, bool>> Criterio){
            return _contexto.sistemas
            .Where(Criterio)
            .AsNoTracking()
            .ToList();

        }
}