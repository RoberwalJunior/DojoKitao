using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos;

public interface IAulaDao : IQuery<Aula>, ICommand<Aula>, IDisposable
{
}
