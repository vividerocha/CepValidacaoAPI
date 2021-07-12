using CepValidacao.API.Models;
using System.Threading.Tasks;

namespace CepValidacao.API.Services
{
    public interface IViaCepHttpService
    {
        Task<EnderecoModel> GetByCep(string cep);
    }
}