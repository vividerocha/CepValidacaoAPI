using CepValidacao.API.Extensions;
using CepValidacao.API.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CepValidacao.API.Services
{
    public class ViaCepHttpService : HttpServiceBase, IViaCepHttpService
    {
        private readonly HttpClient _httpClient;

        public ViaCepHttpService(HttpClient httpClient,
                                      IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<EnderecoModel> GetByCep(string cep)
        {
            var response = await _httpClient.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");

            return await DeserializeObjectResponse<EnderecoModel>(response);
        }
    }
}