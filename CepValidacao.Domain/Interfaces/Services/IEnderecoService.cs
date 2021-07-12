using CepValidacao.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CepValidacao.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {

        Task<Endereco> GetByCep(string cep);

    }
}