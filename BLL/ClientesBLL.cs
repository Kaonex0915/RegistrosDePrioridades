using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

public class ClientesBLL{
    private Contexto _contexto; 
    
    public ClientesBLL(Contexto contexto)
    {
        _contexto = contexto;

    }

    public bool Existe(int Id){
        return _contexto.clientes.Any(c => c.ClienteId == Id);
    }

    public bool Insertar(Clientes clientes){
        _contexto.clientes.Add(clientes);
        var insertado = _contexto.SaveChanges();
        return insertado > 0;
        }

        public bool Modificar(Clientes clientes){
        _contexto.clientes.Update(clientes);
        var modificado = _contexto.SaveChanges();
        return modificado > 0;
        }

        public bool Guardar(Clientes clientes){
            if (!Existe(clientes.ClienteId) ){
                return Insertar(clientes);                
            } 
            else {
                return Modificar(clientes);
            }
        }

        public bool Eliminar(Clientes clientes){
        _contexto.clientes.Remove(clientes);
        var eliminado = _contexto.SaveChanges();
        return eliminado > 0;
        }


        public Clientes? Buscar(int Id){
            return _contexto.clientes
            .AsNoTracking()
            .SingleOrDefault(c => c.ClienteId == Id);
        }

        public List<Clientes> Listar(Expression<Func<Clientes, bool>> Criterio){
            return _contexto.clientes
            .Where(Criterio)
            .AsNoTracking()
            .ToList();

        }
}