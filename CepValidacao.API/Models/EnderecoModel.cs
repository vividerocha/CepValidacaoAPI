using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace CepValidacao.API.Models
{
    public class EnderecoModel
    {
        [JsonPropertyName("cep")]
        public string cep { get; set; }
      
        [JsonPropertyName("logradouro")]
        public string logradouro { get; set; }
        
        [JsonPropertyName("complemento")]
        public string complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string localidade { get; set; }
        
        [JsonPropertyName("uf")]
        public string uf { get; set; }

      
    }
}
