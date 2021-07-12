using System.Collections.Generic;

namespace CepValidacao.Domain.Entities
{
    public class Endereco : Entity<int>
    {
        public Endereco()
        {

        }

        #region Properties

        public string CEP { get; set; }

        public string Logradrouro { get; set; }        

        public string Localidade { get; set; }

        public string UF { get; set; }

        public string Bairro { get; set; }
        
        #endregion

    }
}