using AutoMapper;
using FilmesApi.Data.Dtos.Endereco;
using FilmesApi.Models;



namespace FilmesApi.Profiles
{
    public class EnderecoProfile: Profile
    {
        public EnderecoProfile() {
            CreateMap<CreateEnderecoDto, Enderecos>();
            CreateMap<Enderecos, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Enderecos>();
        }
    }
}
