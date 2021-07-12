using CepValidacao.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CepValidacao.Domain.Interfaces.DataAccess
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco, int>
    {
        Task<Endereco> GetByCep(string cep);
    }
}