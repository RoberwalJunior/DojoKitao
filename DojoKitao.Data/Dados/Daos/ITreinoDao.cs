using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos;

public interface ITreinoDao : ICommand<Treino>
{
    IEnumerable<Treino> BuscarTodos();
    Treino? ConsultarTreinoPorId(int alunoId, int aulaId);
}
