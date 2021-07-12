using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CepValidacao.Domain.Interfaces.DataAccess
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : class
    {

        Task<TEntity> GetByCep(string cep);

        void Dispose();
    }
}