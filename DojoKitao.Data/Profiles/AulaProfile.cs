using AutoMapper;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Profiles;

public class AulaProfile : Profile
{
    public AulaProfile()
    {
        CreateMap<CreateAulaDto, Aula>();
        CreateMap<Aula, ReadAulaDto>()
            .ForMember(aulaDto => aulaDto.Alunos,
                opt => opt.MapFrom(aula => 
                    aula.Treinos.Select(treino => treino.Aluno.Nome)))
            .ForMember(aulaDto => aulaDto.Data,
                opt => opt.MapFrom(aula => 
                    aula.Data.ToString("dddd, dd/MM/yyyy HH:mm")));
    }
}
