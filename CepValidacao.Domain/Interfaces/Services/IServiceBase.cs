using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CepValidacao.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity, TId> where TEntity : class
    {

        Task<TEntity> GetByCep(string id);

    }
}