using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
    }
}
