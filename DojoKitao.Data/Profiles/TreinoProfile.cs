using AutoMapper;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Profiles;

public class TreinoProfile : Profile
{
	public TreinoProfile()
	{
        CreateMap<CreateTreinoDto, Treino>();
        CreateMap<Treino, ReadTreinoDto>();
    }
}
