using AutoMapper;
using oficinaAPI.Data.Dtos.Veiculo;
using oficinaAPI.Models;

namespace oficinaAPI.Profiles
{
    public class VeiculoProfile : Profile
    {
        public VeiculoProfile() 
        {
            CreateMap<CreateVeiculoDto, Veiculo>();
            CreateMap<Veiculo, ReadVeiculoDto>();
            CreateMap<Veiculo, UpdateVeiculoDto>();
            CreateMap<UpdateVeiculoDto, Veiculo>();
        }
    }
}
