using CepValidacao.Domain.Interfaces.DataAccess;
using CepValidacao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CepValidacao.ApplicationService
{
    public class ServiceBase<TEntity, TId> : IServiceBase<TEntity, TId> where TEntity : class
    {
        #region Fields
        protected readonly IRepositoryBase<TEntity, TId> repositoryBase;
        #endregion

        #region Constructors
        public ServiceBase(IRepositoryBase<TEntity, TId> repositoryBase) => this.repositoryBase = repositoryBase;
        #endregion

        #region IServiceBase

        public virtual async Task<TEntity> GetByCep(string cep)
        {
            return await this.repositoryBase.GetByCep(cep);
        }
        #endregion
    }
}