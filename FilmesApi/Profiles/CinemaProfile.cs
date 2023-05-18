using AutoMapper;
using FilmesApi.Data.Dtos.Cinema;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinemas>();
            CreateMap<Cinemas, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.EnderecoDto, 
                    opt => opt.MapFrom(cinema => cinema.Endereco))
                .ForMember(cinemaDto => cinemaDto.Sessoes,
                    opt => opt.MapFrom(cinema => cinema.Sessoes));
            CreateMap<UpdateCinemaDto, Cinemas>();
        }
    }
}
