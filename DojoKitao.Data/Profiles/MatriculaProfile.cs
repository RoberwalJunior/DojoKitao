using AutoMapper;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Profiles;

public class MatriculaProfile : Profile
{
    public MatriculaProfile()
    {
        CreateMap<Matricula, ReadMatriculaDto>();
    }
}
