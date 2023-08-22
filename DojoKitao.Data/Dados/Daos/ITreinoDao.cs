using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos;

public interface ITreinoDao : ICommand<Treino>, IDisposable
{
    IEnumerable<Treino> BuscarTodos();
    Treino? ConsultarTreinoPorId(int alunoId, int aulaId);
}
