using AutoMapper;
using oficinaAPI.Data.Dtos.Servico;
using oficinaAPI.Models;

namespace oficinaAPI.Profiles
{
    public class ServicoProfile : Profile
    {
        public ServicoProfile() 
        {
            CreateMap<CreateServicoDto, Servico>();
            CreateMap<Servico, ReadServicoDto>();
            CreateMap<Servico, UpdateServicoDto>();
            CreateMap<UpdateServicoDto, Servico>();
        }
    }
}
