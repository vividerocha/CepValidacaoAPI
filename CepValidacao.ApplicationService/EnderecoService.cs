using CepValidacao.Domain.Entities;
using CepValidacao.Domain.Interfaces.DataAccess;
using CepValidacao.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CepValidacao.ApplicationService
{
    public class EnderecoService : ServiceBase<Endereco, int>, IEnderecoService
    {
        private readonly IEnderecoRepository enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            this.enderecoRepository = enderecoRepository;
        }
        public async Task<Endereco> GetByCep(string cep)
        {
            return await this.enderecoRepository.GetByCep(cep);
        }
    }
}