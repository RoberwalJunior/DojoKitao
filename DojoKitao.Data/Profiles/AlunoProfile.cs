using AutoMapper;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Profiles;

public class AlunoProfile : Profile
{
    public AlunoProfile()
    {
        CreateMap<CreateAlunoDto, Aluno>();
        CreateMap<Aluno, ReadAlunoDto>()
            .ForMember(alunoDto => alunoDto.Matricula,
                opt => opt.MapFrom(aluno => aluno.Matricula))
            .ForMember(alunoDto => alunoDto.Treinos,
                opt => opt.MapFrom(aluno => aluno.Treinos));
    }
}
