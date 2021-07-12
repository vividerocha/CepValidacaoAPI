using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CepValidacao.API.Services
{
    public abstract class HttpServiceBase
    {
        protected StringContent GetStringContent(object data)
        {
            return new StringContent(
                JsonSerializer.Serialize(data),
                Encoding.UTF8,
                "application/json");
        }

        protected async Task<T> DeserializeObjectResponse<T>(HttpResponseMessage responseMessage)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<T>(await responseMessage.Content.ReadAsStringAsync(), options);
        }

        protected bool HandleErrorsResponse(HttpResponseMessage responseMessage)
        {
            switch ((int)responseMessage.StatusCode)
            {
                case 401:
                case 403:
                case 404:
                case 500:
                case 400:
                    return false;
            }

            responseMessage.EnsureSuccessStatusCode();
            return true;
        }
    }
}