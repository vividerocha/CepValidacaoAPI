using AutoMapper;
using CepValidacao.API.Models;
using CepValidacao.Domain.Entities;
using AutoMapper.Extensions.EnumMapping;

namespace CepValidacao.API.AutoMapper
{
    public class ApiMapper : Profile
    {
        public ApiMapper()
        {

            CreateMap<Endereco, EnderecoModel>();

            
        }
    }
}