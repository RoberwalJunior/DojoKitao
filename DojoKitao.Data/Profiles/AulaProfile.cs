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
            .ForMember(aulaDto => aulaDto.Treinos,
                opt => opt.MapFrom(aula => aula.Treinos));
    }
}
