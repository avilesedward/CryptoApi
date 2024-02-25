using AutoMapper;
using crypto.api.Dtos;
using crypto.domain.entities;

namespace crypto.api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CurrencyMinDto, CurrencyEntity>();
            CreateMap<CurrencyEntity, CurrencyMinDto>();

            CreateMap<CurrencyDto, CurrencyEntity>();
            CreateMap<CurrencyEntity, CurrencyDto>();
        }
    }
}