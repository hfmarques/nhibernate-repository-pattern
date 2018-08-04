using AutoMapper;
using NHibernate.Core.Dto;
using NHibernate.Core.Models;

namespace NHibernate.Core.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Endereco, EnderecoDto>();
            CreateMap<Hotel, HotelDto>();
            CreateMap<Quarto, QuartoDto>();
        }
    }
}
