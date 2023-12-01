using AutoMapper;
using oficinaAPI.Data.Dtos.Cliente;
using oficinaAPI.Models;

namespace oficinaAPI.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() 
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<Cliente, UpdateClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
        }
    }
}
