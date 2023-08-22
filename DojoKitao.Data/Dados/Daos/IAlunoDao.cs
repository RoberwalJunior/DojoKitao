using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos;

public interface IAlunoDao : IQuery<Aluno>, ICommand<Aluno>, IDisposable
{
}
