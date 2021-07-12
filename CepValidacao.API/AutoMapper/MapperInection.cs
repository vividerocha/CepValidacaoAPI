using Microsoft.Extensions.DependencyInjection;

namespace CepValidacao.API.AutoMapper
{
    public static class MapperInection
    {
        public static IServiceCollection UseApiMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(ApiMapper));
            return service;
        }
    }
}