using AutoMapper;
using oficinaAPI.Data.Dtos.TipoServico;
using oficinaAPI.Models;

namespace oficinaAPI.Profiles
{
    public class TipoServicoProfile : Profile
    {
        public TipoServicoProfile() 
        {
            CreateMap<CreateTipoServicoDto, TipoServico>();
            CreateMap<TipoServico, ReadTipoServicoDto>();
            //CreateMap<TipoServico, UpdateTipoServicoDto>();
        }
    }
}
