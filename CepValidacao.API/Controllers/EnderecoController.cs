using Microsoft.AspNetCore.Mvc;
using CepValidacao.API.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace CepValidacao.API.Controllers
{
    
    [Route("[controller]")]
    [EnableCors]
    public class EnderecoController : ControllerBase
    {
        //[HttpGet("{cep}")]
        [HttpPost("{cep}")]
        public async Task<string> GetCep(string cep)
        {
            HttpClient cliente = new HttpClient();
            HttpResponseMessage resposta = await cliente.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");
            
            resposta.EnsureSuccessStatusCode();

            return await resposta.Content.ReadAsStringAsync();
        }

    }
}
