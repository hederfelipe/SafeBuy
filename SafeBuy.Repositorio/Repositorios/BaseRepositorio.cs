using SafeBuy.Dominio.Contratos;
using SafeBuy.repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafeBuy.repositorio.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        
        protected readonly SafeBuyContexto SafeBuyContexto;
        

        public BaseRepositorio(SafeBuyContexto safeBuyContexto)
        {
            SafeBuyContexto = safeBuyContexto;
        }

        public void Adicionar(TEntity entity)
        {
            SafeBuyContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            SafeBuyContexto.Set<TEntity>().Update(entity);
            SafeBuyContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return SafeBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return SafeBuyContexto.Set<TEntity>().ToList();

        }

        public void Remover(TEntity entity)
        {
            SafeBuyContexto.Remove(entity);
            SafeBuyContexto.SaveChanges();
        }

     

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseRepositorio()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            SafeBuyContexto.Dispose();
        }
    }
}
