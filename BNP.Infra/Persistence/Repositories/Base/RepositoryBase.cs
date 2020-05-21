using BNP.Domain.Entities.Base;
using BNP.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BNP.Infra.Persistence.Repositories.Base
{
    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade>
         where TEntidade : EntityBase
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext context)
        {
            _dbContext = context;
        }

        public TEntidade Adicionar(TEntidade entidade)
        {
            return _dbContext.Set<TEntidade>().Add(entidade);
        }

        public IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public TEntidade Editar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Func<TEntidade, bool> where)
        {
            return _dbContext.Set<TEntidade>().Any(where);
        }

        public IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            IQueryable<TEntidade> query = _dbContext.Set<TEntidade>();

            if(includeProperties.Any())
            {
                return Include(_dbContext.Set<TEntidade>(), includeProperties);
            }

            return query;
        }

        public IQueryable<TEntidade> ListarEOrdenadosPor<TKey>(Expression<Func<TEntidade, bool>> where, Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> ListarOrdenadosPor<TKey>(Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPor(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adicionar um coleção de entidades ao contexto do entity framework
        /// </summary>
        /// <param name="entidades">Lista de entidades que deverão ser persistidas</param>
        /// <returns></returns>
        //public IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades)
        //{
        //    return _context.Set<TEntidade>().AddRange(entidades);
        //}

        /// <summary>
        /// Verifica se existe algum objeto com a condição informada
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        //public bool Existe(Func<TEntidade, bool> where)
        //{
        //    return _context.Set<TEntidade>().Any(where);
        //}

        /// <summary>
        /// Realiza include populando o objeto passado por parametro
        /// </summary>
        /// <param name="query">Informe o objeto do tipo IQuerable</param>
        /// <param name="includeProperties">Ínforme o array de expressões que deseja incluir</param>
        /// <returns></returns>
        private IQueryable<TEntidade> Include(IQueryable<TEntidade> query, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query;
        }
    }
}
